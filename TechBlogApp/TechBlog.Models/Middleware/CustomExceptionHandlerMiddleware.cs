using LeadingEdgeServer.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Net;

namespace TechBlog.Models.Middleware
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionHandlerMiddleware> _logger;

        public CustomExceptionHandlerMiddleware(RequestDelegate next, ILogger<CustomExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            //catch (SqlException ex)
            //{
            //    Exception exception = ex;
            //    if (ex != null && ex.ErrorCode != null && ex.ErrorCode == -2146232060)
            //    {
            //        exception = new Exception("Failed to connect with system database. Please try again later.");
            //    }

            //    await HandleExceptionAsync(context, exception);
            //}
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
            finally
            {  
                Console.WriteLine("Final Call");
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            string errorMessage = exception.Message;
            if (exception != null && exception.HResult != null && exception.HResult == -2146232060)
            {
                errorMessage = "Failed to connect with system database. Please try again later.";
            }

            var code = HttpStatusCode.InternalServerError;

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            context.Response.AddApplicationError(errorMessage);
            _logger.LogError(errorMessage);
            if (exception.InnerException != null) _logger.LogCritical(exception.InnerException.Message);

            var result = JsonConvert.SerializeObject(new { error = errorMessage });


            return context.Response.WriteAsync(result);
        }
    }
}

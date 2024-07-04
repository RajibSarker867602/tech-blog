using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TechBlog.Models.Filters
{
    /// <summary>
    /// Input Model validation error(s) handling
    /// </summary>
    public class ValidateModelFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = new List<string>();

                foreach (var value in context.ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }

                var errorMessage = string.Join(", ", errors);

                context.Result = new BadRequestObjectResult(errorMessage);
            }
        }
    }
}
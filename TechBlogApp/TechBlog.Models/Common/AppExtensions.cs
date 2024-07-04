using LeadingEdgeServer.Models.Paging;
using LeadingEdgeServer.Models.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using TechBlog.Models.Common;
using TechBlog.Models.Common.Results;

namespace LeadingEdgeServer.Models.Common
{
    /// <summary>
    /// Extension method will be add here
    /// </summary>
    public static class AppExtensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
        }

        public static string GetMD5EncryptedText(this string value)
        {
            return MD5CryptoService.GetEncryptedText(value);
        }

        public static string GetMD5DecryptedText(this string value)
        {
            return MD5CryptoService.GetDecryptedText(value);
        }

        public static void AddPagination(this HttpResponse response, int currentPage, int itemPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemPerPage, totalItems, totalPages);
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }

        public static void AddResponseFileName(this HttpResponse response, string fileName)
        {
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            response.Headers.Add("FileName", JsonConvert.SerializeObject(fileName, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Headers", "FileName");
        }

        public static Guid ToGuid(this Guid? source)
        {
            return source ?? Guid.Empty;
        }

        // more general implementation
        public static T ValueOrDefault<T>(this Nullable<T> source) where T : struct
        {
            return source ?? default(T);
        }

        public static string ConvertDateTime(this DateTime datetime)
        {
            var year = datetime.Year.ToString();
            var month = datetime.Month.ToString();
            var day = datetime.Day.ToString();

            return $"{year}-{month}-{day}";
        }

        public static string GetEnumTitle(this System.Enum enumValue, bool isDescriptioin)
        {
            if (enumValue is null)
            {
                throw new ArgumentNullException(nameof(enumValue));
            }
            if (isDescriptioin)
            {
                var field = enumValue.GetType().GetField(enumValue.ToString());
                if (field != null && Attribute.GetCustomAttribute(field!, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    return attribute.Description;
                }

                return enumValue.ToString();
            }
            else
            {
                return enumValue.ToString();
            }
        }

        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTimeStamp);
        }

        public static string GetFormatedDateOnly(this DateTime dateTime)
        {
            return dateTime.ToString("dd-MMM-yyyy");
        }

        /// <summary>
        /// Create new anonymous object with selective properties
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="originalObj"></param>
        /// <param name="properties"></param>
        /// <returns>Create new anonymous object with selective properties</returns>
        public static dynamic MapToResponse<TSource>(this TSource originalObj, params Expression<Func<TSource, object>>[] properties)
        {
            dynamic response = new ExpandoObject();

            foreach (var property in properties)
            {
                string properName = originalObj.GetMemberName(property);
                var propertyInfo = typeof(TSource).GetProperty(properName);
                if (propertyInfo != null)
                {
                    ((IDictionary<string, object>)response)[properName] = propertyInfo.GetValue(originalObj);
                }
            }

            return response;
        }

        /// <summary>
        /// Create API response of anonymous object with selective properties
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="originalObj"></param>
        /// <param name="properties"></param>
        /// <returns>Create API response of anonymous object with selective properties</returns>
        public static ApplicationSuccessResponse<dynamic> MapToResponse<TSource>(this ApplicationSuccessResponse<TSource> originalObj,
            params Expression<Func<TSource, object>>[] properties) where TSource : new()
        {
            dynamic response = new ExpandoObject();

            foreach (var property in properties)
            {
                string properName = originalObj.Data.GetMemberName(property);
                var propertyInfo = typeof(TSource).GetProperty(properName);
                if (propertyInfo != null)
                {
                    ((IDictionary<string, object>)response)[properName] = propertyInfo.GetValue(originalObj.Data);
                }
            }

            return new ApplicationSuccessResponse<dynamic>()
            {
                Data = response,
                Message = originalObj.Message
            };
        }

        /// <summary>
        /// Gets an unique number
        /// </summary>
        /// <returns>Returns an unique number</returns>
        public static string GenerateUniqueNumber(int digitToTake)
        {
            // Get the current timestamp
            long timestamp = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            Random random = new Random();
            int randomComponent = random.Next(100000, 999999);

            // Combine timestamp and random component
            string uniqueNumber = $"{timestamp}{randomComponent}";

            if (uniqueNumber.Length > digitToTake)
            {
                uniqueNumber = uniqueNumber.Substring(0, digitToTake);
            }

            return uniqueNumber;
        }
    }
}
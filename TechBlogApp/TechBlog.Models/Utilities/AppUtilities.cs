using LeadingEdgeServer.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Utilities
{
    public class AppUtilities
    {
        /// <summary>
        /// Generate tree from flat data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="searchFunc"></param>
        /// <param name="getIdFunc"></param>
        /// <param name="getParentIdFunc"></param>
        /// <param name="getChildFunc"></param>
        /// <returns>Tree with nested child</returns>
        public static ICollection<T> GenerateTreeData<T>(ICollection<T> data, Func<T, bool> searchFunc, Func<T, Guid?> getIdFunc, Func<T, Guid?> getParentIdFunc, Func<T, ICollection<T>> getChildFunc) where T : class
        {
            var returnData = new List<T>();

            while (data.Any())
            {
                data.ToList().ForEach((item) =>
                {
                    var childs = getChildFunc(item);
                    childs = new List<T>();

                    var parentId = getParentIdFunc(item);

                    if (parentId is null || searchFunc(item))
                    {
                        var existingData = data.FirstOrDefault(c => getIdFunc(c) == getIdFunc(item));

                        if (existingData != null)
                        {
                            data.Remove(item);
                        }

                        returnData.Add(item);
                    }
                    else
                    {
                        SearchParent(returnData, parentId, item, data, getIdFunc, getParentIdFunc, getChildFunc);
                    }
                });
            }

            return returnData;
        }

        /// <summary>
        /// Search parent data from tree data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="treeData"></param>
        /// <param name="parentId"></param>
        /// <param name="currentData"></param>
        /// <param name="data"></param>
        /// <param name="getIdFunc"></param>
        /// <param name="getParentIdFunc"></param>
        /// <param name="getChildFunc"></param>
        private static void SearchParent<T>(List<T> treeData, Guid? parentId, T currentData, ICollection<T> data, Func<T, Guid?> getIdFunc, Func<T, Guid?> getParentIdFunc, Func<T, ICollection<T>> getChildFunc) where T : class
        {
            treeData.ForEach((parent) =>
            {
                var childs = getChildFunc(parent);
                if (getIdFunc(parent) == parentId)
                {
                    childs.Add(currentData);

                    var existingCOA = data.FirstOrDefault(c => getIdFunc(c) == getIdFunc(currentData));
                    if (existingCOA != null)
                    {
                        data.Remove(currentData);
                    }
                }
                else
                {
                    SearchParent<T>((List<T>)childs, parentId, currentData, data, getIdFunc, getParentIdFunc, getChildFunc);
                }
            });
        }

        /// <summary>
        /// Generate entity AutoGenCode
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="serialNo"></param>
        /// <returns></returns>
        public static string GenerateEntityAutoGenCode(string prefix, long serialNo)
        {
            if (serialNo <= 0) return string.Empty;

            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            if (!string.IsNullOrEmpty(prefix) && prefix.Length > 4)
            {
                prefix = prefix.Substring(0, 4);
            }

            string withoutPrefix = string.Format($"{currentYear}{currentMonth.ToString("D2")}{serialNo}");

            return string.IsNullOrEmpty(prefix) ? withoutPrefix : string.Format($"{prefix}{withoutPrefix}");
        }

        /// <summary>
        /// Barcode length
        /// </summary>
        private static int BarcodeLength = 12;

        /// <summary>
        /// Generate barcode text with 12 characters long and the combination of numbers and characters
        /// </summary>
        /// <param name="prefix">Prefix of the barcode, it can be null</param>
        /// <param name="serialNo">Unique serial no for the item from entity table</param>
        /// <returns>Returns a barcode with 12 character long</returns>
        public static string GenerateBarCodeText(string prefix, long serialNo)
        {
            if (serialNo <= 0) return string.Empty;

            var dateTimeTicks = DateTime.Now.Ticks;

            string uniqueNo = AppExtensions.GenerateUniqueNumber(BarcodeLength - serialNo.ToString().Length);

            if (!string.IsNullOrEmpty(prefix) && prefix.Length > 4)
            {
                prefix = prefix.Substring(0, 4);

                uniqueNo = uniqueNo.Substring(0, (BarcodeLength - (prefix.Length + serialNo.ToString().Length)));
            }

            string withoutPrefix = string.Format($"{uniqueNo}{serialNo}");

            return string.IsNullOrEmpty(prefix) ? withoutPrefix : string.Format($"{prefix}{withoutPrefix}");
        }
    }
}

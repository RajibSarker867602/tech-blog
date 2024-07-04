using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Enum.Inventory;
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
        /// Get security feature by entity name
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static SecurityFeatureEnum? GetFeatureByEntityName(string entityName, dynamic? entity)
        {
            if (string.IsNullOrEmpty(entityName) || entity == null) return null;

            SecurityFeatureEnum securityFeatureEnum = new SecurityFeatureEnum();
            switch (entityName)
            {
                #region Common Module
                case "UserConnection":
                    securityFeatureEnum = SecurityFeatureEnum.UserConnection;
                    break;
                case "CommonMenuModulePermission":
                    securityFeatureEnum = SecurityFeatureEnum.CommonMenuModulePermission;
                    break;
                case "CommonCurrencyConversion":
                    securityFeatureEnum = SecurityFeatureEnum.CommonCurrencyConversion;
                    break;
                case "CommonProjectCurrency":
                    securityFeatureEnum = SecurityFeatureEnum.CommonProjectCurrency;
                    break;
                #endregion

                #region Security Module
                #endregion

                #region Accounts Module
                case "AccountsBank":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsBank;
                    break;
                case "AccountsCOAMaster":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsCOAMaster;
                    break;
                case "AccountsCOADetails":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsCOADetails;
                    break;
                case "AccountsCOABank":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsCOABank;
                    break;
                case "AutoVoucherMappingConfiguration":
                    securityFeatureEnum = SecurityFeatureEnum.AutoVoucherMappingConfiguration;
                    break;
                case "AccountsFiscalYear":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsFiscalYear;
                    break;
                case "AccountsModulesTransaction":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsModulesTransaction;
                    break;
                case "AccountsMonthClosing":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsMonthClosing;
                    break;
                case "AccountsBankChequeRegister":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsBankChequeRegister;
                    break;
                case "AccountsBankChequeForward":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsBankChequeForward;
                    break;
                case "AccountsVoucherApproval":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsVoucherApproval;
                    break;
                case "AccountsOpeningBalanceMaster":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsOpeningBalanceMaster;
                    break;
                case "AccountsOpeningBalanceDetails":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsOpeningBalanceDetails;
                    break;
                case "SupplierCustomerTransections":
                    securityFeatureEnum = SecurityFeatureEnum.SupplierCustomerTransections;
                    break;
                case "AccountsVoucherMaster":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsVoucherMaster;
                    break;
                case "AccountsVoucherDetail":
                    securityFeatureEnum = SecurityFeatureEnum.AccountsVoucherDetail;
                    break;
                #endregion

                #region Inventory Module
                case "InventoryItemBrand":
                    securityFeatureEnum = SecurityFeatureEnum.InventoryItemBrand;
                    break;
                case "InvCategory":
                    securityFeatureEnum = SecurityFeatureEnum.InvCategory;
                    break;
                case "InventoryItemStore":
                    securityFeatureEnum = SecurityFeatureEnum.InventoryItemStore;
                    break;
                case "InventoryItemInformation":
                    securityFeatureEnum = SecurityFeatureEnum.InventoryItemInformation;
                    break;
                case "InventorySupplierCustomer":
                    securityFeatureEnum = SecurityFeatureEnum.InventorySupplierCustomer;
                    break;
                case "InventoryItemUnitConvertion":
                    securityFeatureEnum = SecurityFeatureEnum.InventoryItemUnitConvertion;
                    break;
                case "InvItemTransactionMaster":
                    if (entity.GetType().GetProperty("TransactionType") != null)
                    {
                        switch (entity.GetType().GetProperty("TransactionType").GetValue(entity, null))
                        {
                            case InvFeatureEnum.ItemReceive:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemReceiveMaster;
                                break;
                            case InvFeatureEnum.ItemTransfer:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemTransferMaster;
                                break;
                            case InvFeatureEnum.ItemIssue:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemIssueMaster;
                                break;
                            case InvFeatureEnum.ItemReceiveReturn:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemReceiveReturnMaster;
                                break;
                            case InvFeatureEnum.Process:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemProcessMaster;
                                break;
                            case InvFeatureEnum.ItemSales:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemSales;
                                break;
                            case InvFeatureEnum.ItemSalesReturn:
                                securityFeatureEnum = SecurityFeatureEnum.InventoryItemSalesReturn;
                                break;
                            default:
                                securityFeatureEnum = SecurityFeatureEnum.InvItemTransactionMaster;
                                break;
                        }
                    }
                    break;
                case "InvItemTransactionDetails":
                    securityFeatureEnum = SecurityFeatureEnum.InventoryItemTransactionDetails;
                    break;
                case "InvItemOpeningBalance":
                    securityFeatureEnum = SecurityFeatureEnum.InvItemOpeningBalance;
                    break;
                #endregion

                #region Purchase Module
                case "PurchaseOrderMaster":
                    securityFeatureEnum = SecurityFeatureEnum.PurchaseOrderMaster;
                    break;
                case "PurchaseOrderDetails":
                    securityFeatureEnum = SecurityFeatureEnum.PurchaseOrderDetails;
                    break;
                #endregion

                #region Payroll Module
                case "PayrollDepartment":
                    securityFeatureEnum = SecurityFeatureEnum.PayrollDepartment;
                    break;
                #endregion

                #region Donor Module
                case "Donor":
                    securityFeatureEnum = SecurityFeatureEnum.Donor;
                    break;
                #endregion
                default:
                    break;
            }

            return securityFeatureEnum;
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

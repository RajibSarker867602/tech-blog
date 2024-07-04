using LeadingEdgeServer.Models.Entity.Accounts.OpeningBalance;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.OpeningBalance
{
    public class OpeningBalanceCreationDto
    {
        public OpeningBalanceCreationDto()
        {
            OpeningBalanceDetails = new List<OpeningBalanceDetailsDto>();
            SupplierCustomerDetailTransections = new List<SupplierCustomerOpeningBalanceCreateDto>();
            InvItemOpeningBalances = new List<InvItemOpeningBalanceCreateDto>();
        }
        //public Guid ProjectId { get; set; }
        public string TransactionType { get; set; }
        public DateTime OpeningDate { get; set; }
        public IFormFile? File { get; set; }
        public Guid? StoreId { get; set; }
        public Guid? FiscalYearId { get; set; }
        public Guid CurrencyId { get; set; }
        public double ConvertionRate { get; set; }
        public ICollection<OpeningBalanceDetailsDto>? OpeningBalanceDetails { get; set; }
        public ICollection<SupplierCustomerOpeningBalanceCreateDto>? SupplierCustomerDetailTransections { get; set; }
        public ICollection<InvItemOpeningBalanceCreateDto>? InvItemOpeningBalances { get; set; } 
    }

    public class OpeningBalanceDetailsDto
    {
        public Guid? AssetsCOAId { get; set; }
        public double? AssetsOpeningBalance { get; set; }
        public string? AssetsCOAType { get; set; }
        public Guid? LiabilitiesCOAId { get; set; }
        public double? LiabilitiesOpeningBalance { get; set; }
        public string? LiabilitiesCOAType { get; set; }
    }
}

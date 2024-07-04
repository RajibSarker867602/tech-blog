using LeadingEdgeServer.Models.SQL.StoredProcedures;

namespace LeadingEdgeServer.Models.Response.Accounts.VoucherEntry
{
    public record AccountsVoucherListResponseDto
    {
        public AccountsVoucherListResponseDto()
        {
            AccountsVoucherListDate = new List<GetVoucherMastersByCriteria_SP>();
        }
        public int RecordCount { get; set; }
        public ICollection<GetVoucherMastersByCriteria_SP> AccountsVoucherListDate { get;set; }
    }
}

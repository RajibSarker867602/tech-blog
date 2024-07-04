using System.Web;

namespace LeadingEdgeServer.Models.Paging
{
    /// <summary>
    /// Searchable model with few properties
    /// </summary>
    public class PageParams
    {
        private const int MaxPageSize = 100;
        /// <summary>
        /// Define the page number
        /// </summary>
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        private string _searchKey = string.Empty;
        /// <summary>
        /// Define the page size here
        /// </summary>
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        /// <summary>
        /// Enter search key here
        /// </summary>
        public string? SearchKey 
        {
            get => _searchKey;
            set => _searchKey = !string.IsNullOrEmpty(value) ? HttpUtility.UrlDecode(value) : value;
        }
        /// <summary>
        /// Enter the sorting column name, if needs to sorting the response data
        /// </summary>
        public string SortingItem { get; set; } = string.Empty;
        /// <summary>
        /// Define the sort direction, ex: 'asc'/'desc'
        /// </summary>
        public string SortDirection { get; set; } = "asc";
        /// <summary>
        /// User id (nullable)
        /// </summary>
        public Nullable<Guid> UserId { get; set; }
        /// <summary>
        /// Project id (nullable)
        /// </summary>
        public Nullable<Guid> ProjectId { get; set; }
        public bool IsAll { get; set; }
    }
}

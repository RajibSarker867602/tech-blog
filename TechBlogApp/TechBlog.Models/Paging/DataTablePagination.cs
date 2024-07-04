using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadingEdgeServer.Models.Paging;

namespace TechBlog.Models.Paging
{
    /// <summary>
    /// Data table pagination request params and response dto
    /// </summary>
    /// <typeparam name="TEntity">Pagination data list return type</typeparam>
    /// <typeparam name="TSearch">Pagination search model type</typeparam>
    public class DataTablePagination<TEntity, TSearch> : PageParams
    {
        // Pagination data list return type
        public ICollection<TEntity> DataList { get; set; }
        //Pagination search model type
        public TSearch Search { get; set; }
        public PaginationHeader? Pagination { get; set; }
    }
}
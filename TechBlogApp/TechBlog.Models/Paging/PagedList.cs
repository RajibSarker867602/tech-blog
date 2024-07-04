using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechBlog.Models.Paging
{
    public class PagedList<TEntity> : List<TEntity>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public PagedList(List<TEntity> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }

        public static async Task<PagedList<TEntity>> CreateAsync(IQueryable<TEntity> source, int pageNumber, int pageSize, bool isAll = false)
        {
            var count = await source.CountAsync();
            if(isAll == true)
            {
                return new PagedList<TEntity>(await source.ToListAsync(), count, pageNumber, pageSize);
            }
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagedList<TEntity>(items, count, pageNumber, pageSize);
        }
        public static PagedList<TEntity> Create(IQueryable<TEntity> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<TEntity>(items, count, pageNumber, pageSize);
        }
    }
}

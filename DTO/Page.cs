using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarnestsWebApi.DTO
{
    public class Page
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Floor(TotalCount / (double)PageSize);
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
        public string sortBy { get; set; }
        public string sortDirection { get; set; }
    }
}
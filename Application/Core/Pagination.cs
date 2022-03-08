using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class Pagination
    {
        public Pagination(int pageSize, int pageNumber, int total)
        {
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.Total = total;

        }
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
        public int Total { get; set; }
        //public IReadOnlyList<T> Data { get; set; }
    }
}

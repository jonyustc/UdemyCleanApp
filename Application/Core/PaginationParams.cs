using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    
    public class PaginationParams
    {
        private const int MaxPageSize = 50;
        public string Sort { get; set; }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public int? SellerId { get; set; }
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 6;
        public int PageSize
        {
            get => _pageSize;
            set
            {
                _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }

        private string _search;
        public string Search
        {
            get => _search;
            set
            {
                _search = value.ToLower();
            }
        }
    }
}

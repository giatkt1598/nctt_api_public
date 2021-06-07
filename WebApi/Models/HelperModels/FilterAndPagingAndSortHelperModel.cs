using DataService.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Constants;

namespace WebApi.Models.HelperModels
{
    public class FilterAndPagingAndSortHelperModel
    {
        public string Fields { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; } = ApiConfig.Paging.DefaultSize;
        public string SortOrderBy { get; set; }
        public SortDirection? SortDirection { get; set; }

    }
}

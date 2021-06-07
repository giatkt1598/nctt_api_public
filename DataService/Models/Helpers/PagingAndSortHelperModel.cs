using DataService.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.Helpers
{
    public class PagingAndSortHelperModel
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public int DefaultSize { get; set; }
        public int LimitSize { get; set; }
        public string Fields { get; set; }
        public SortDirection? SortDirection { get; set; }
        public string SortOrderBy { get; set; }
    }
}

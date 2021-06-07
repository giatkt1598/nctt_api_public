using DataService.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.Helpers
{
    public class DynamicAndPagingHelperModel : PagingAndSortHelperModel
    {
        public Dictionary<string, string> PropertyKeyValues { get; set; }
    }

}

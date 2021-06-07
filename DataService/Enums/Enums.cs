using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataService.Enums
{
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortDirection
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }
}

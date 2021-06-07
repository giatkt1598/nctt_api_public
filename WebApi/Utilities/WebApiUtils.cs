using DataService.Models.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApi.Constants;
using WebApi.Models.HelperModels;

namespace WebApi.Utilities
{
    public static class WebApiUtils
    {

        public static Dictionary<string, string> ConvertModelToDictionary<TModel>(TModel model)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach(PropertyInfo property in typeof(TModel).GetProperties())
            {
                string value = property.GetValue(model)?.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    dictionary.Add(property.Name, value);
                }
            }
            return dictionary;
        }

        public static DynamicAndPagingHelperModel ConvertToDynamicAndPagingHelperModel<TModel>
            (TModel model, FilterAndPagingAndSortHelperModel dynamicPagingSortModelHelper)
        {
            return new DynamicAndPagingHelperModel
            {
                PropertyKeyValues = ConvertModelToDictionary(model),
                DefaultSize = ApiConfig.Paging.DefaultSize,
                LimitSize = ApiConfig.Paging.LimitSize,
                Size = dynamicPagingSortModelHelper.Size ?? ApiConfig.Paging.DefaultSize,
                Fields = dynamicPagingSortModelHelper.Fields,
                Page = dynamicPagingSortModelHelper.Page ?? 1,
                SortDirection = dynamicPagingSortModelHelper.SortDirection,
                SortOrderBy = dynamicPagingSortModelHelper.SortOrderBy,
            };
        }

        public static PagingAndSortHelperModel ConvertToPagingHelperModel(FilterAndPagingAndSortHelperModel model)
        {
            return new PagingAndSortHelperModel
            {
                DefaultSize = ApiConfig.Paging.DefaultSize,
                LimitSize = ApiConfig.Paging.LimitSize,
                Size = model.Size ?? ApiConfig.Paging.DefaultSize,
                Fields = model.Fields,
                Page = model.Page ?? 1,
                SortDirection = model.SortDirection,
                SortOrderBy = model.SortOrderBy
            };
        }
    }
}

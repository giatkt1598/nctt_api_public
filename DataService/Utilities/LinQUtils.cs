using DataService.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace DataService.Utilities
{
    public static class LinQUtils
    {

        /// <summary>
        ///     Dynamic Query, Dynamic Model
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TResult">Class tương tự <typeparamref name="TEntity"/> nhưng các property của nó có nullable</typeparam>
        /// <param name="source"></param>
        /// <param name="dictionary"> Tương đương Where(x => x.[key] == dictionary[key].value)</param>
        /// <param name="fields">Mảng property name của <typeparamref name="TResult"/> cần lấy</param>
        /// <returns></returns>
        public static IQueryable<TResult> GetUsingDictionaryAndFilter<TEntity, TResult>(IQueryable<TEntity> source,
            Dictionary<string, string> dictionary, string fields)
        {
            if (dictionary != null)
            {
                foreach (var item in dictionary)
                {
                    bool isDateTime = typeof(TEntity).GetProperty(item.Key).PropertyType == typeof(DateTime)
                        || typeof(TEntity).GetProperty(item.Key).PropertyType == typeof(DateTime?);
                    if (isDateTime)
                    {
                        DateTime dt = DateTime.Parse(item.Value);
                        source = source.Where($"{item.Key} >= @0 && {item.Key} < @1", dt.Date, dt.Date.AddDays(1));
                    }
                    else
                    {
                        if (typeof(TEntity).GetProperty(item.Key).PropertyType == typeof(string))
                        {
                            source = source.Where($"{item.Key} = \"{item.Value}\"");
                        }
                        else
                        {
                            source = source.Where($"{item.Key} = {item.Value}");
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(fields))
            {
                fields = string.Join(',', typeof(TEntity).GetProperties().Select(s => s.Name).ToArray());
            }
            return source.Select<TResult>(ToDynamicSelector(fields));
        }

        public static IOrderedQueryable<TModel> Sort<TModel>(IQueryable<TModel> source, 
            string sortOrderBy = null, SortDirection? sortDirection = null)
        {
            if (!string.IsNullOrEmpty(sortOrderBy))
            {
                sortOrderBy = sortOrderBy.ToLower().Replace("_", "").Replace("-", "");
                if (typeof(TModel).GetProperties().FirstOrDefault(x => x.Name.ToLower() == sortOrderBy) != null)
                {
                    if (sortDirection == null || sortDirection == SortDirection.Asc)
                    {
                        source = source.OrderBy(sortOrderBy + " ASC");
                    }
                    else if (sortDirection == SortDirection.Desc)
                    {
                        source = source.OrderBy(sortOrderBy + " DESC");
                    }
                }
            }
            return source as IOrderedQueryable<TModel>;
        }

        /// <summary>
        ///     Dynamic Model
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static IQueryable<TResult> GetUsingFilter<TEntity, TResult>(IQueryable<TEntity> source, string fields)
        {
            if (string.IsNullOrEmpty(fields))
            {
                fields = string.Join(',', typeof(TResult).GetProperties().Select(s => s.Name).ToArray());
            }
            return source.Select<TResult>(ToDynamicSelector(fields));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="defaultSize"></param>
        /// <param name="limitSize"></param>
        /// <returns>Item1: 'Total' of entity | Item2: 'IQueryable' after paging</returns>
        public static (int, IQueryable<TResult>) PagingIQueryable<TResult>(IQueryable<TResult> source, int page, int size, int defaultSize, int limitSize)
        {
            if (size > limitSize)
            {
                size = limitSize;
            }
            if (size < 1)
            {
                size = defaultSize;
            }
            if (page < 1)
            {
                page = 1;
            }
            int total = source.Count();
            IQueryable<TResult> results = source
                .Skip((page - 1) * size)
                .Take(size);
            return (total, results);
        }

        public static (int, IEnumerable<TResult>) PagingIEnumerable<TResult>(IEnumerable<TResult> source, int page, int size, int defaultSize, int limitSize)
        {
            if (size > limitSize)
            {
                size = limitSize;
            }
            if (size < 1)
            {
                size = defaultSize;
            }
            if (page < 1)
            {
                page = 1;
            }
            int total = source.Count();
            IEnumerable<TResult> results = source
                .Skip((page - 1) * size)
                .Take(size);
            return (total, results);
        }

        public static string ToDynamicSelector(string selectors)
        {
            return @"new {" + selectors.Replace("-", string.Empty).Replace("_", string.Empty) + "}";
        }

    }
}

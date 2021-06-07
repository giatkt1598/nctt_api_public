using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.ResponseModels
{
    public class DynamicModelsResponse<T>
    {
        public PagingMetadata Metadata { get; set; }
        public List<T> Data { get; set; }

        public static DynamicModelsResponse<T> TransformToMe((int, IEnumerable<T>) model, int page)
        {
            return new DynamicModelsResponse<T>
            {
                Metadata = new PagingMetadata
                {
                    Page = page,
                    Size = model.Item2.Count(),
                    Total = model.Item1
                },
                Data = model.Item2.ToList()
            };
        }
    }
}

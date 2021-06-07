﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.ResponseModels
{
    public class PagingMetadata
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public int Total { get; set; }
    }
}

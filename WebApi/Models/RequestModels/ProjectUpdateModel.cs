﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.RequestModels
{
    public class ProjectUpdateModel
    {
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

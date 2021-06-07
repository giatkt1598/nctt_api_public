using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.ViewModels
{
    public class ProjectViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedId { get; set; }
        public int? CreatedUserId { get; set; }
        public bool? Actived { get; set; }
    }
}

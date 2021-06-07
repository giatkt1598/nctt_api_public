using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.ViewModels
{
    public  class FormViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? ProjectId { get; set; }
        public bool? Gps { get; set; }
        public bool? Microphone { get; set; }
        public bool? Camera { get; set; }
        public bool? Record { get; set; }
        public bool? Location { get; set; }
        public bool? Actived { get; set; }
    }
}

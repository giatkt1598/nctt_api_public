using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.ViewModels
{
    public  class SectionViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public int FormId { get; set; }
        public bool Ordered { get; set; }
        public int NextSectionId { get; set; }
        public TimeSpan TimeRequired { get; set; }
        public bool Actived { get; set; }
    }
}

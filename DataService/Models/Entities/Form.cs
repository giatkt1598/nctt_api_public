using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Form
    {
        public Form()
        {
            LocationFormSettings = new HashSet<LocationFormSetting>();
            Responses = new HashSet<Response>();
            Sections = new HashSet<Section>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int? ProjectId { get; set; }
        public bool Gps { get; set; }
        public bool Microphone { get; set; }
        public bool Camera { get; set; }
        public bool Record { get; set; }
        public bool Location { get; set; }
        public bool Actived { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<LocationFormSetting> LocationFormSettings { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}

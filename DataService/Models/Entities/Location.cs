using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Location
    {
        public Location()
        {
            LocationFormSettings = new HashSet<LocationFormSetting>();
            Responses = new HashSet<Response>();
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Address { get; set; }
        public bool Actived { get; set; }

        public virtual ICollection<LocationFormSetting> LocationFormSettings { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
    }
}

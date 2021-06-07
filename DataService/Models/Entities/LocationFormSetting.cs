using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class LocationFormSetting
    {
        public int Id { get; set; }
        public int MaximumAnswer { get; set; }
        public int Answerded { get; set; }
        public int FormId { get; set; }
        public int LocationId { get; set; }
        public bool Actived { get; set; }

        public virtual Form Form { get; set; }
        public virtual Location Location { get; set; }
    }
}

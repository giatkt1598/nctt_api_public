using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class ResponseSection
    {
        public int Id { get; set; }
        public TimeSpan CompletedTime { get; set; }
        public bool OnTime { get; set; }
        public int SectionId { get; set; }
        public int ResponseId { get; set; }
        public bool Actived { get; set; }

        public virtual Response Response { get; set; }
        public virtual Section Section { get; set; }
    }
}

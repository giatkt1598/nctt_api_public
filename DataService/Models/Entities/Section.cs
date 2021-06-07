using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Section
    {
        public Section()
        {
            Options = new HashSet<Option>();
            Questions = new HashSet<Question>();
            ResponseSections = new HashSet<ResponseSection>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public int FormId { get; set; }
        public bool Ordered { get; set; }
        public int NextSectionId { get; set; }
        public TimeSpan TimeRequired { get; set; }
        public bool Actived { get; set; }

        public virtual Form Form { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ResponseSection> ResponseSections { get; set; }
    }
}

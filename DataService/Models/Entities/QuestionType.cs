using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public bool Actived { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}

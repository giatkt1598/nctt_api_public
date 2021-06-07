using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Option
    {
        public Option()
        {
            ResponseDetailValueOptionColumns = new HashSet<ResponseDetail>();
            ResponseDetailValueOptionRows = new HashSet<ResponseDetail>();
        }

        public int Id { get; set; }
        public string TextValue { get; set; }
        public int Position { get; set; }
        public int QuestionId { get; set; }
        public int? NextSectionId { get; set; }
        public int? NextQuestionId { get; set; }
        public string GroupName { get; set; }
        public bool UsingAnswerMap { get; set; }
        public bool Actived { get; set; }

        public virtual Question NextQuestion { get; set; }
        public virtual Section NextSection { get; set; }
        public virtual ICollection<ResponseDetail> ResponseDetailValueOptionColumns { get; set; }
        public virtual ICollection<ResponseDetail> ResponseDetailValueOptionRows { get; set; }
    }
}

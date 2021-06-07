using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Question
    {
        public Question()
        {
            InversePreQuestion = new HashSet<Question>();
            Options = new HashSet<Option>();
            ResponseQuestions = new HashSet<ResponseQuestion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public bool Required { get; set; }
        public int? PreQuestionId { get; set; }
        public bool Completed { get; set; }
        public int QuestionTypeId { get; set; }
        public int SectionId { get; set; }
        public int MinResponses { get; set; }
        public int MaxResponses { get; set; }
        public bool AllowGps { get; set; }
        public int MaximumNumberFile { get; set; }
        public int MaximumFileSize { get; set; }
        public string AcceptedExtension { get; set; }
        public bool Ordered { get; set; }
        public string TimesEmotion { get; set; }
        public bool Actived { get; set; }

        public virtual Question PreQuestion { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<Question> InversePreQuestion { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<ResponseQuestion> ResponseQuestions { get; set; }
    }
}

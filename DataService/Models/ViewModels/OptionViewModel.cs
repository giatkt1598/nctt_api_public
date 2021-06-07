using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.ViewModels
{
    public class OptionViewModel
    {
        public int Id { get; set; }
        public string TextValue { get; set; }
        public int Position { get; set; }
        public int QuestionId { get; set; }
        public int? NextSectionId { get; set; }
        public int? NextQuestionId { get; set; }
        public string GroupName { get; set; }
        public bool UsingAnswerMap { get; set; }
        public bool Actived { get; set; }
    }
}

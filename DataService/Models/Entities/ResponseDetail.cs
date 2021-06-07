using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class ResponseDetail
    {
        public ResponseDetail()
        {
            FileResponses = new HashSet<FileResponse>();
        }

        public int Id { get; set; }
        public int Position { get; set; }
        public string DateType { get; set; }
        public string ValueText { get; set; }
        public int ResponseQuestionId { get; set; }
        public int ValueOptionRowId { get; set; }
        public int ValueOptionColumnId { get; set; }
        public TimeSpan Time { get; set; }
        public string Image { get; set; }
        public string Emotion { get; set; }
        public string MeasureEmotion { get; set; }
        public bool MatchEmotion { get; set; }
        public bool Actived { get; set; }

        public virtual ResponseQuestion ResponseQuestion { get; set; }
        public virtual Option ValueOptionColumn { get; set; }
        public virtual Option ValueOptionRow { get; set; }
        public virtual ICollection<FileResponse> FileResponses { get; set; }
    }
}

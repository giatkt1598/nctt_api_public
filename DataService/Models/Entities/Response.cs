using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Response
    {
        public Response()
        {
            ResponseQuestions = new HashSet<ResponseQuestion>();
            ResponseSections = new HashSet<ResponseSection>();
        }

        public int Id { get; set; }
        public DateTime AnswerTime { get; set; }
        public DateTime SubmitTime { get; set; }
        public int LocationId { get; set; }
        public int Status { get; set; }
        public int? UserId { get; set; }
        public int FormId { get; set; }
        public bool MicrophoneOn { get; set; }
        public bool EnableCameraOn { get; set; }
        public bool RecordOn { get; set; }
        public string RecordValue { get; set; }
        public bool MatchLocation { get; set; }
        public bool Actived { get; set; }

        public virtual Form Form { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ResponseQuestion> ResponseQuestions { get; set; }
        public virtual ICollection<ResponseSection> ResponseSections { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class ResponseQuestion
    {
        public ResponseQuestion()
        {
            ResponseDetails = new HashSet<ResponseDetail>();
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int ResponseId { get; set; }
        public int Status { get; set; }
        public bool Actived { get; set; }

        public virtual Question Question { get; set; }
        public virtual Response Response { get; set; }
        public virtual ICollection<ResponseDetail> ResponseDetails { get; set; }
    }
}

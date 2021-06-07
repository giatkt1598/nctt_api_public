using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class FileResponse
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public int ResponseDetailId { get; set; }
        public bool Actived { get; set; }

        public virtual ResponseDetail ResponseDetail { get; set; }
    }
}

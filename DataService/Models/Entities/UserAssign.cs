using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class UserAssign
    {
        public int Id { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public bool Actived { get; set; }

        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
    }
}

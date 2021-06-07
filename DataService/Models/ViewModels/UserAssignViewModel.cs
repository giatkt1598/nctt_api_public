using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.ViewModels
{
    public partial class UserAssignViewModel
    {
        public int Id { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public bool Actived { get; set; }

        public virtual UserViewModel User { get; set; }
    }
}

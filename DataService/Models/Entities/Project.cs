using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Project
    {
        public Project()
        {
            Forms = new HashSet<Form>();
            UserAssigns = new HashSet<UserAssign>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedId { get; set; }
        public int? CreatedUserId { get; set; }
        public bool Actived { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<UserAssign> UserAssigns { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class Role
    {
        public Role()
        {
            RoleClaims = new HashSet<RoleClaim>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool Actived { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}

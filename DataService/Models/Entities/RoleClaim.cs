﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataService.Models.Entities
{
    public partial class RoleClaim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Role Role { get; set; }
    }
}

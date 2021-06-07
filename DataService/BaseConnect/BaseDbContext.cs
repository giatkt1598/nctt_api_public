﻿using DataService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataService.BaseConnect
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext()
        {

        }
        public BaseDbContext(DbContextOptions<NCTTContext> options) : base(options) { }
        protected BaseDbContext(DbContextOptions options) : base(options) { }
    }
}

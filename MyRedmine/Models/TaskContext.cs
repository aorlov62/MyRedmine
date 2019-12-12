using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyRedmine.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }

        public DbSet<Priority> Prioritys { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<SpendTime> SpendTimes { get; set; }
    }
}
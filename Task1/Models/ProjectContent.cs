using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Task1.Models
{
    public class ProjectContext : DbContext
    {

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
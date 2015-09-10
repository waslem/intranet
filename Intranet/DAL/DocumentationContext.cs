using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Intranet.DAL
{
    public class DocumentationContext : DbContext
    {
        public DocumentationContext() : base("DocumentationContext")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Documentation> Documentations { get; set; }
        public DbSet<Entry> Entries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
 	        base.OnModelCreating(modelBuilder);
        }
    }
}
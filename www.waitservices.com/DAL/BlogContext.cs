using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using www.waitservices.com.Models;

namespace www.waitservices.com.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogContext")
        {
        }

        public DbSet <Comment> Comments { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
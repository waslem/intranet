using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using www.waitservices.com.Models;

namespace www.waitservices.com.DAL
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext()
            : base("MyDbContext")
        {
        }

        public static MyDbContext Create()
        {
            return new MyDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<IdentityUser>().ToTable("Users");
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
            modelBuilder.Entity<ApplicationUser>().HasRequired(x => x.Blog).WithRequiredPrincipal();

            base.OnModelCreating(modelBuilder);


        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
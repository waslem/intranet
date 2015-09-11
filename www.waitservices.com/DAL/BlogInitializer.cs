using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using www.waitservices.com.Models;

namespace www.waitservices.com.DAL
{
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            context.SaveChanges();

        }
    }
}
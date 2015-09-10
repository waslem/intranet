using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.DAL
{
    public class DocumentationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DocumentationContext>
    {
        protected override void Seed(DocumentationContext context)
        {
            var categories = new List<Category>
            {
                new Category { Description = "VMWare", Name = "VMWare"}
            };

            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

        }
    }
}
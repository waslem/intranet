using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.waitservices.com.Models
{
    public class Tag
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Entry Entry { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.waitservices.com.Models
{
    public class Blog
    {
        public int ID { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
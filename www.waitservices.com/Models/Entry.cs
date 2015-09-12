using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.waitservices.com.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
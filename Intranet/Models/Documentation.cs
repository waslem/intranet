using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.Models
{
    public class Documentation
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastModified { get; set; }
        public string CreatedBy { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
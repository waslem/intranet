using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.waitservices.com.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string CommentText { get; set; }

        public virtual Entry Entry { get; set; }

        public virtual ICollection<Comment> ChildComments { get; set; }

    }
}
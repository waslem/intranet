using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.waitservices.com.Models
{
    public class ContactForm
    {
        public int ID { get; set; }

        public DateTime Submitted { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
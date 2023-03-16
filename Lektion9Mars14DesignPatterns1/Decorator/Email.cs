using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Decorator
{
    public class Email
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string EmailToSendTo { get; set; }
        public Email(string title, string body, string emailToSendTo)
        {
            Title = title;
            Body = body;
            EmailToSendTo = emailToSendTo;
        }
    }
}

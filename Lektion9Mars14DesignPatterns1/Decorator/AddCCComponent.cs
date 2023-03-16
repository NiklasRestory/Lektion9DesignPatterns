using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Decorator
{
    public class AddCCComponent : EmailDecorator
    {
        string ccEmail;
        public AddCCComponent(IEmailSenderComponent next, string ccEmail) : base(next) 
        {
            this.ccEmail = ccEmail;
        }

        // Each one of the components then first do their thing, then call the next
        // component in the line.
        public override void SendEmailOperation(Email email)
        {
            Console.WriteLine("Sending " + email.Title + " email to " + ccEmail);
            next.SendEmailOperation(email);
        }
    }
}

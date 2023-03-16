using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Decorator
{
    public class SendEmailComponent : IEmailSenderComponent
    {
        // The final component does not inherit from the decorator,
        // for there is no more component to call from here. But
        // because it implements the Component interface, it can
        // be in a list with the others.
        public void SendEmailOperation(Email email)
        {
            Console.WriteLine("Email " + email.Title + " sent!");
        }
    }
}

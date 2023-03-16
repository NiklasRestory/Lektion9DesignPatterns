using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Decorator
{
    public abstract class EmailDecorator : IEmailSenderComponent
    {
        protected IEmailSenderComponent next;
        // The decorator is a static class that contains the next component to be called.
        // Each component can inherit from this one if they are to call the next component
        // in the series. Because it implements the component interface, so does all the
        // classes that inherit from this class.
        public EmailDecorator(IEmailSenderComponent next)
        {
            this.next = next;
        }
        public abstract void SendEmailOperation(Email email);
    }
}

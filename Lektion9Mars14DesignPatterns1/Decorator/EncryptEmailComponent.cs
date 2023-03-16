using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Decorator
{
    public class EncryptEmailComponent : EmailDecorator
    {
        public EncryptEmailComponent(IEmailSenderComponent next) : base(next)
        {
        }

        public override void SendEmailOperation(Email email)
        {
            Console.WriteLine("Encrypting the " + email.Title + " email!");
            next.SendEmailOperation(email);
        }
    }
}

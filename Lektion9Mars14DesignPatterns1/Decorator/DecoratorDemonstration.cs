using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Decorator
{
    public class DecoratorDemonstration
    {
        public void Run()
        {
            // When used, the Decorator pattern allows us to create a line of functions
            // that are called one after another. Note we can put any of our components
            // in any order we wish, it just has to end with one programmed for it.
            IEmailSenderComponent sendEmailComponent = new SendEmailComponent();
            IEmailSenderComponent addCCComponent = new AddCCComponent(sendEmailComponent, "ccmail@hotmail.com");
            IEmailSenderComponent addCCComponent2 = new AddCCComponent(addCCComponent, "ccmail@hotmail.com");
            IEmailSenderComponent encryptEmailComponent = new EncryptEmailComponent(addCCComponent2);
            IEmailSenderComponent encryptEmailComponent2 = new EncryptEmailComponent(encryptEmailComponent);

            Email email = new Email("Important email", "Please turn on the power, we can't work here.", "manager@mail.com");

            encryptEmailComponent2.SendEmailOperation(email);
        }
    }
}

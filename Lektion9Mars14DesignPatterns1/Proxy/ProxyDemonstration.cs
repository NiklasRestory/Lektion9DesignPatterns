using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Proxy
{
    public class ProxyDemonstration
    {
        public void Run()
        {
            BookDatabase bookDatabase = new BookDatabase();

            // We can get all the proxies in the beginning so we can look
            // through them, but not the objects themselves.
            List<BookProxy> bookProxies = bookDatabase.GetProxies();

            bookProxies[0].PrintInfo();
            bookProxies[0].PrintInfo();
            bookProxies[0].PrintInfo();
            bookProxies[1].PageCount = 345;
            bookProxies[1].PrintInfo();

            Console.WriteLine("There are " + bookProxies.Count + " proxies.");
        }
    }
}

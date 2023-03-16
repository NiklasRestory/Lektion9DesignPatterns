using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1.Proxy
{
    public class BookDatabase
    {
        public Book GetBookByTitle(string title)
        {
            return new Book(title, 100, "Fantasy", "A decent dude", "English", 299);
        }

        public List<BookProxy> GetProxies()
        {
            List<BookProxy> proxies = new List<BookProxy>();
            proxies.Add(new BookProxy("Cool Book", this));
            proxies.Add(new BookProxy("Lame Book", this));
            proxies.Add(new BookProxy("Happy Book", this));
            proxies.Add(new BookProxy("Historical Book", this));

            return proxies;
        }
    }
}

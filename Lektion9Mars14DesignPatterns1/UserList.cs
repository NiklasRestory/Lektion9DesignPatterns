using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9Mars14DesignPatterns1
{
    public class UserList
    {
        DatabaseConnection dbc;
        List<User> users = new List<User>();

        public UserList(DatabaseConnection dbc, List<User> users)
        {
            this.dbc = dbc;
            this.users = users;
        }
        public UserList()
        {
            dbc = new DatabaseConnection();
        }

        public void LoadUsers()
        {
            users = dbc.LoadUsers();
        }
    }
}

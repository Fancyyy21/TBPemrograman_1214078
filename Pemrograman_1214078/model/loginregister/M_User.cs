using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model
{
    internal class M_User
    {
        string id, username, password;

        public M_User()
        {

        }

        public M_User(string id, string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model.superadmin
{
    internal class M_superadmin
    {
        string id, username, password;

        public M_superadmin()
        {

        }

        public M_superadmin(string id, string username, string password)
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

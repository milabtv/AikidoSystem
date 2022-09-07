using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Account
    {
        private string username;
        private string password;
        private string access;
        public Account()
        {
            this.username = "";
            this.password = "";
            this.access = "";
        }

        public Account(string username, string password, string access)
        {
            this.username = username;
            this.password = password;
            this.access = access;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Access { get => access; set => access = value; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_JSON.Model
{
    internal class Usuario
    {
        public String username { get; set; }
        public String email { get; set; }
        public String password { get; set; }

        public Usuario(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Librarian
    {
        private static int counter = 0;

        private int id { get; set; }
        private string login { get; set; }
        private string password { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Librarian(string login, string password, string firstName, string lastName)
        {
            this.id = ++counter;
            this.login = login;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int GetId()
        {
            return id;   
        }
    }
}

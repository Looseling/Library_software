using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public class User
    {
        private static int counter = 0;

        private int id { get; }
        private string login { get; set; }
        private string password { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }

        public User(string login, string password, string firstName, string lastName)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public class Librarian : User
    {
        public Librarian(string login, string password, string firstName, string lastName)
            : base(login, password, firstName, lastName)
        {
        }
    }
}

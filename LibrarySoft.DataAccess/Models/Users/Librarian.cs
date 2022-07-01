using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public class Librarian : BaseUser
    {
        public Librarian()
            : base()
        {
            CreateLogin();
        }
        public override void CreateLogin()
        {
            this.login = firstName + "." + lastName + "@LibWorker.com";
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public abstract class BaseUser : ILoggable
    {
        [Key]
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        string ILoggable.login { get; set; }
        string ILoggable.password { get; set; }


        public bool SignIn(string login, string _password)
        {
            if (this.login == login && this. password == password)
            {
                return true;
            }
            return false;
        }

        public abstract void CreateLogin();
    }
}

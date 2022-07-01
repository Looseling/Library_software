using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public interface ILoggable
    {
        string login { get; set; }
        string password { get; set; }
        bool SignIn(string _login, string _password);
        void CreateLogin();
    }
}

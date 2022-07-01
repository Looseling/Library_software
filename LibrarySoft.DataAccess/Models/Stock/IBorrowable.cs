using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{
    public interface IBorrowable
    {
        Lending lended { get; set; }
        void Borrow(Lending l);
    }
}

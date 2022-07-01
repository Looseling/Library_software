using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibControlApp
{ 
    public interface ISearchable
    {

        // Seems sus to me... 
        static Book Search(LibraryContext _db, string title) => throw new NotImplementedException();
    }
}

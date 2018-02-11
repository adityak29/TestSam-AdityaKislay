using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Interfaces
{
    interface IFizzBuzzRepository
    {
        IEnumerable<string> GetDisplay(int input);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_NegativeNumberException
{
    class NegativeNumberException: ApplicationException
    {
        public NegativeNumberException(): base("Illegal operation for a negative number")
        {}

        public NegativeNumberException(string message): base(message)
        {}

        public NegativeNumberException(string message, Exception inner): base(message, inner)
        {}
    }
}

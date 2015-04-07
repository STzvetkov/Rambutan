using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Exceptions
{
    class UnitNotFoundException : Exception
    {
        public UnitNotFoundException()
        {
        }

        public UnitNotFoundException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public UnitNotFoundException(string message, Exception inner) : base(message, inner)
        {
            Console.WriteLine(message);
        }
    }
}
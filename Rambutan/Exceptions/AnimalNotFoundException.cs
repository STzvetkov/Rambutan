using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Exceptions
{
    class AnimalNotFoundException : Exception
    {
        public AnimalNotFoundException()
        {
        }

        public AnimalNotFoundException(string message) : base(message)
        {
        }

        public AnimalNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
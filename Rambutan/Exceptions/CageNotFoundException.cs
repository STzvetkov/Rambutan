using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Exceptions
{
    class CageNotFoundException: Exception
    {
        public CageNotFoundException()
        {
        }

        public CageNotFoundException(string message) : base(message)
        {
        }

        public CageNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

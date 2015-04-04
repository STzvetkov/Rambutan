using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Exceptions
{
    public class NoMenuException : Exception
    {
        public NoMenuException()
        {
        }

        public NoMenuException(string msg)
            :base(msg)
        {
        }

        public NoMenuException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

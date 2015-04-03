using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Common
{
    public class NoMenuException : Exception
    {
        public NoMenuException(string msg)
            :base(msg)
        {
        }
    }
}

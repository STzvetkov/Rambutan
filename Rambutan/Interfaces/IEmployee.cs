using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zoo.Employees;

namespace Zoo.Interfaces
{
    interface IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Position Position { get; }
    }
}

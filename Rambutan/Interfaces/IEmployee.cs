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
        string FirstName { get; }
        string LastName { get; }
        Position Position { get; }
    }
}

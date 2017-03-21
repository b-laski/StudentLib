using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Exceptions
{
    public class InvalidAccess : Exception
    {
        public InvalidAccess(string date) : base(date)
        {
               
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Exceptions
{
    class ServerError : Exception
    {
        public ServerError(string date) : base(date)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Exceptions
{
    class FacebookProfileNotAvailable : Exception
    {
        public FacebookProfileNotAvailable(string data) : base (data)
        {

        }
    }
}

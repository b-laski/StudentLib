using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Exceptions
{
    public class InvalidAccessToken : Exception
    {
        public InvalidAccessToken(string data) : base(data)
        {

        }
    }
}

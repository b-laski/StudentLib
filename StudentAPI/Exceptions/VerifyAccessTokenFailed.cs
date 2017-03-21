using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Exceptions
{
    class VerifyAccessTokenFailed : Exception
    {
        public VerifyAccessTokenFailed(string data) : base(data)
        {

        }
    }
}

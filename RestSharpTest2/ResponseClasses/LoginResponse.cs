using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTest2.ResponseClasses
{


    internal class LoginResponse
    {
        public LoginResponseData data { get; set; }

        public bool success { get; set; }

    }
}

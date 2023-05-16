using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTest2.ResponseClasses
{
    internal class CameraListResponse
    {
        public CameraListResponseData data { get; set; }
        public Boolean success { get; set; }
                
    }
}

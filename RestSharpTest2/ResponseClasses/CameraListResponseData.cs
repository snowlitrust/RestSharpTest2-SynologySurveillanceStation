using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTest2.ResponseClasses
{
    internal class CameraListResponseData
    {
        public List<Camera> cameras { get; set; }
        public int total { get; set; }


    }
}

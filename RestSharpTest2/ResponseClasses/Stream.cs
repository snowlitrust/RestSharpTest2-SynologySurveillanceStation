using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTest2.ResponseClasses
{
    internal class Stream
    {
        public int bitrateCtrl { get; set; }
        public string constantBitrate { get; set; }

        public int fps { get; set; }

        public string quality { get; set; }

        public string resolution { get; set; }
    }
}

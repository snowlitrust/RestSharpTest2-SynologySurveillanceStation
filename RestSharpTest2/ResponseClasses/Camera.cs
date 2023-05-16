using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTest2.ResponseClasses
{
    internal class Camera
    {

        public int DINum { get; set; }
        public int DONum { get; set; }
        public Stream stream1 { get; set; }
        public int audioCodec { get; set; }
        public string channel { get; set; }
        public int dsId { get; set; }
        public Boolean enableLowProfile { get; set; }
        public Boolean enableRecordingKeepDays { get; set; }
        public Boolean enableRecordingKeepSize { get; set; }
        public string fov { get; set; }
        public int id { get; set; }
        public string ip { get; set; }
        public string model { get; set; }
        public string newName { get; set; }
        public int port { get; set; }
        public int postRecordTime { get; set; }
        public int preRecordTime { get; set; }
        public int recordTime { get; set; }
        public int recordingKeepDays { get; set; }
        public string recordingKeepSize { get; set; }
        public int status { get; set; }
        public int tvStandard { get; set; }
        public string vendor { get; set; }
        public int videoCodec { get; set; }

        public CameraDetailInfo detailInfo { get; set; }
    }
}

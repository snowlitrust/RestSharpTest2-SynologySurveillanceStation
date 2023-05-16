

using Microsoft.VisualBasic;
using RestSharp;
using RestSharpTest2.ResponseClasses;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;


namespace RestSharpTest2
{
    public partial class Form1 : Form
    {
        string theSID = "";
        string theDownloadID = "";
        string theRecordingID = "";
        string theRecordingFileExtension = "";

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonGo_Click(object sender, EventArgs e)
        {
            getLoginCastToClassAsync();
           //getLoginWithoutCastingAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getInfoAsync();
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.doLogoutAsync();
        }

        async void doLogoutAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";


            //url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/auth.cgi?api=SYNO.API.Auth&method=login&version=1&account=hin&passwd=hin&session=SurveillanceStation";

            url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/auth.cgi?api=SYNO.API.Auth&method=logout&version=1&session=SurveillanceStation";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);

            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/auth.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.API.Auth");
            newrequest.AddParameter("method", "logout");
            newrequest.AddParameter("version", "1");
            newrequest.AddParameter("session", "SurveillanceStation");


            this.labelActualURLUsed.Text = url;

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                 this.textBox1.Text = "Successful:" + newresponse.Content;

                //var unknownObject = JsonDocument.Parse(newresponse.Content);
                //this.textBox1.Text = "Successful:" + unknownObject.RootElement.GetProperty("data").GetProperty("sid");
                //this.theSID = unknownObject.RootElement.GetProperty("data").GetProperty("sid").ToString();
                //this.labelSID.Text = this.theSID;
                //foreach(var oneData in theData.EnumerateArray())
                //{
                //    this.textBox1.Text = "Successful:" + oneData.GetProperty("xyz");
                //}               

            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        async void getLoginWithoutCastingAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";


            //url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/auth.cgi?api=SYNO.API.Auth&method=login&version=1&account=hin&passwd=hin&session=SurveillanceStation";

            url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/auth.cgi";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);

            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.API.Auth");
            newrequest.AddParameter("method", "login");
            newrequest.AddParameter("version", "6");
            newrequest.AddParameter("account", "h");
            newrequest.AddParameter("passwd", "h");
            newrequest.AddParameter("session", "SurveillanceStation");
            newrequest.AddParameter("format", "sid");


            this.labelActualURLUsed.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
               // this.textBox1.Text = "Successful:" + newresponse.Content;
               
                var unknownObject = JsonDocument.Parse(newresponse.Content);
                this.textBox1.Text = "Successful:" + unknownObject.RootElement.GetProperty("data").GetProperty("sid");
                this.theSID = unknownObject.RootElement.GetProperty("data").GetProperty("sid").ToString();
                this.labelSID.Text = this.theSID;
                //foreach(var oneData in theData.EnumerateArray())
                //{
                //    this.textBox1.Text = "Successful:" + oneData.GetProperty("xyz");
                //}               

            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        async void getLoginCastToClassAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";


            //url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/auth.cgi?api=SYNO.API.Auth&method=login&version=1&account=hin&passwd=hin&session=SurveillanceStation";

            url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/auth.cgi";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);

            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.API.Auth");
            newrequest.AddParameter("method", "login");
            newrequest.AddParameter("version", "2");
            newrequest.AddParameter("account", "h");
            newrequest.AddParameter("passwd", "h");
            newrequest.AddParameter("session", "SurveillanceStation");
            newrequest.AddParameter("format", "sid");


            this.labelActualURLUsed.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {

                // var JSONobj = 
                //this.textBox1.Text = "Successful:" + newresponse.Content;
                var lr = JsonSerializer.Deserialize<LoginResponse>(newresponse.Content);
                this.textBox1.Text = "Successful:" + lr.data.sid;
                this.labelSID.Text = lr.data.sid;
                this.theSID = lr.data.sid;


            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        async void getInfoAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            //camera list
            // url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/entry.cgi?privCamType=0&version=8&blIncludeDeletedCam=true&streamInfo=true&blPrivilege=false&start=1&api=SYNO.SurveillanceStation.Camera&limit=2&basic=true&blFromCamList=true&camStm=1&method=List";
            //url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/webapi/entry.cgi";

            //info - version
            //url = "https://a112.nvr9demo.synologydemo.com:5001/webapi/query.cgi?api=SYNO.API.Info&method=Query&version=1";
            //url = "https://a112.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/query.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.API.Info");
            newrequest.AddParameter("method", "Query");
            newrequest.AddParameter("version", "1");


            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {

                var unknownObject = JsonDocument.Parse(newresponse.Content);
                this.textBox1.Text = "Successful:  The SYNO.API.Auth's path is :" + 
                        unknownObject.RootElement.GetProperty("data").GetProperty("SYNO.API.Auth").GetProperty("path") +
                        Environment.NewLine +
                        "The content of the newresponse variable is :" + newresponse.Content;
            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        private void buttonDoSomething_Click(object sender, EventArgs e)
        {
            this.getCameraListAsync();
        }

        async void getCameraListAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Camera");
            newrequest.AddParameter("method", "List");
            newrequest.AddParameter("privCamType", "0");
            newrequest.AddParameter("version", "1");
            newrequest.AddParameter("blIncludeDeletedCam", "true");
            newrequest.AddParameter("streamInfo", "true");
            newrequest.AddParameter("Privilege", "false");
            //newrequest.AddParameter("start", "10");
            //newrequest.AddParameter("limit", "3");
            newrequest.AddParameter("basic", "true");
            newrequest.AddParameter("blFromCamList", "false");
            newrequest.AddParameter("camStm", "1");
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");


            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                this.textBox1.Text = "Successful:" + newresponse.Content;

                var lr = JsonSerializer.Deserialize<CameraListResponse>(newresponse.Content);
                this.textBox2.Text = "Successful, camera names are :";
                foreach (Camera item in lr.data.cameras)
                {
                    this.textBox2.Text = this.textBox2.Text + " " + item.id + "-" + item.detailInfo.camName;
                    this.listBoxCameras.Items.Add(String.Format("{0}-{1} ", item.id, item.detailInfo.camName));

                }
                

                /*
                var unknownObject = JsonDocument.Parse(newresponse.Content);
                this.textBox2.Text = "Successful:  Camera 1 :" +
                        unknownObject.RootElement.GetProperty("data").GetProperty("cameras").GetProperty("detailInfo") +
                        Environment.NewLine +
                        "The content of the newresponse variable is :" + newresponse.Content;                
                */
            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        private void buttonSSInfo_Click(object sender, EventArgs e)
        {
            this.getSSInfoAsync();
        }

        async void getSSInfoAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Info");
            newrequest.AddParameter("method", "GetInfo");
            newrequest.AddParameter("version", "1");
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");


            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                this.textBox1.Text = "Successful:" + newresponse.Content;

                /*
                var unknownObject = JsonDocument.Parse(newresponse.Content);
                this.textBox1.Text = "Successful:  The SYNO.API.Auth's path is :" +
                        unknownObject.RootElement.GetProperty("data").GetProperty("SYNO.API.Auth").GetProperty("path") +
                        Environment.NewLine +
                        "The content of the newresponse variable is :" + newresponse.Content;

                */

            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        private void listBoxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.getSnapshotAsync();   
        }

        async void getSnapshotAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Camera");
            newrequest.AddParameter("method", "GetSnapshot");
            newrequest.AddParameter("ProfileType", "0");
            newrequest.AddParameter("version", "9");
            System.Collections.Generic.List<string> cameraIDList = this.listBoxCameras.SelectedItem.ToString().Split('-').ToList();
            newrequest.AddParameter("id", cameraIDList[0].ToString());
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");

            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                this.textBox1.Text = "Successful:" + newresponse.Content;

                // this.pictureBox1.Image = byte.Parse(newresponse.Content.ToString());

                // byte[] lr = JsonSerializer.Deserialize<CameraGetSnapshot>(newresponse.Content);
                //this.pictureBox1.Image = ByteToImage(newresponse.Content);
                //this.pictureBox1.Image = ByteToImage(lr);
                //this.textBox2.Text = "Successful, camera image ready";

                byte[] MyByte = Encoding.ASCII.GetBytes("");
                if (newresponse.RawBytes!= null)
                {
                    MyByte = newresponse.RawBytes;
                }               

                Image MyImg = this.ByteToImage(MyByte);
                pictureBox1.Image = MyImg;
   

            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadVideo_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            startVideoRangeExportAsync();
        }

        async void getRecordingIDAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Recording");
            newrequest.AddParameter("method", "List");
            newrequest.AddParameter("version", "6");
            System.Collections.Generic.List<string> cameraIDList = this.listBoxCameras.SelectedItem.ToString().Split('-').ToList();
            newrequest.AddParameter("camId", cameraIDList[0].ToString());
            newrequest.AddParameter("offset", "0");
            newrequest.AddParameter("limit", "80");
            newrequest.AddParameter("fromTime", "0");
            newrequest.AddParameter("toTime", "0");
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");

            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            String theResult = "No result";
            if (newresponse.IsSuccessful)
            {
                var unknownObject = JsonDocument.Parse(newresponse.Content);
                theResult = unknownObject.RootElement.GetProperty("data").GetProperty("recordings")[0].GetProperty("id").ToString();
                this.textBox1.Text = "recordingid is "+ theResult + ", Successful:" + newresponse.Content;
                this.theRecordingID = theResult;
                getRecordAsync(theResult);
            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }
            

        }

        async void getRecordAsync(String theSpecificRecordingID)
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi/video.mp4", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Recording");
            newrequest.AddParameter("method", "Download");
            newrequest.AddParameter("version", "6");
            newrequest.AddParameter("id", theSpecificRecordingID);
            newrequest.AddParameter("playTimeMs", "2000");
            newrequest.AddParameter("offsetTimeMs", "50000");
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");

            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            String theResult = "No result";
            if (newresponse.IsSuccessful)
            {
                //var unknownObject = JsonDocument.Parse(newresponse.Content);
                this.textBox1.Text = "Successful:getRecordAsync";

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.InitialDirectory = @ "C:\";      
                saveFileDialog1.Title = "Save Video Recordings";
               // saveFileDialog1.CheckFileExists = true;
               // saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "mp4";
                saveFileDialog1.Filter = "*.mp4|*.*";
               // saveFileDialog1.FilterIndex = 2;
               // saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = saveFileDialog1.FileName;
                    File.WriteAllBytes(saveFileDialog1.FileName, newresponse.RawBytes);                    
                }

            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }
            this.Cursor = Cursors.Default;

        }

        async void startVideoRangeExportAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Recording");
            newrequest.AddParameter("method", "RangeExport");

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;

            newrequest.AddParameter("version", "6");
            newrequest.AddParameter("fileName", "video");
            newrequest.AddParameter("fromTime", (secondsSinceEpoch - 20).ToString());
            newrequest.AddParameter("toTime", (secondsSinceEpoch-10).ToString());
            System.Collections.Generic.List<string> cameraIDList = this.listBoxCameras.SelectedItem.ToString().Split('-').ToList();
            newrequest.AddParameter("camId", cameraIDList[0].ToString());
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");

            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                this.textBox1.Text = "Successful:" + newresponse.Content;
                var unknownObject = JsonDocument.Parse(newresponse.Content);
                this.theDownloadID = unknownObject.RootElement.GetProperty("data").GetProperty("dlid").ToString();
                this.buttonLoadVideo.Text = "Loading..." + Environment.NewLine + this.theDownloadID;
                String theProgress = "";
                int theCount = 0;
                while (!theProgress.Equals("100") && theCount < 10)
                {
                    theProgress = await getExportProgress(this.theDownloadID);
                    theCount = theCount+ 1;
                    await Task.Delay(1000);
                }
                getExportedFileAsync();
            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        async void getExportedFileAsync()
        {
            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);


            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Recording");
            newrequest.AddParameter("method", "OnRangeExportDone");
            newrequest.AddParameter("dlid", this.theDownloadID);
            newrequest.AddParameter("version", "6");
            newrequest.AddParameter("fileName", "video");
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");

            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                this.textBox1.Text = "Successful:" + newresponse.Content;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.InitialDirectory = @ "C:\";      
                saveFileDialog1.Title = "Save Video Recordings";
                // saveFileDialog1.CheckFileExists = true;
                // saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "mp4";
                saveFileDialog1.Filter = "*.mp4|*.*";
                // saveFileDialog1.FilterIndex = 2;
                // saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = saveFileDialog1.FileName;
                    File.WriteAllBytes(saveFileDialog1.FileName, newresponse.RawBytes);
                }

            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

        }

        //int result = await getExportProgress();
        async Task<string> getExportProgress(String theDownloadID)
        {
            this.theRecordingFileExtension = "";
            string theProgress = "0";

            string url = "https://THE_SYNOLOGY_VM.nvr9demo.synologydemo.com:5001/";

            url = url.Replace("THE_SYNOLOGY_VM", this.textBoxServerPrefix.Text);
            this.labelActualURLUsed.Text = "url used is : " + url;
            RestClient newclient = new RestClient(url);

            RestRequest newrequest = new RestRequest("webapi/entry.cgi", Method.Get);

            newrequest.AddParameter("api", "SYNO.SurveillanceStation.Recording");
            newrequest.AddParameter("method", "GetRangeExportProgress");
            newrequest.AddParameter("version", "6");
            newrequest.AddParameter("dlid", theDownloadID);
            newrequest.AddParameter("_sid", "\"" + this.theSID + "\"");

            this.textBox1.Text = newrequest.ToString();

            RestResponse newresponse = await newclient.ExecuteAsync(newrequest);
            if (newresponse.IsSuccessful)
            {
                var unknownObject = JsonDocument.Parse(newresponse.Content);
                theProgress = unknownObject.RootElement.GetProperty("data").GetProperty("progress").ToString();
                this.theRecordingFileExtension = unknownObject.RootElement.GetProperty("data").GetProperty("fileExt").ToString();
            }
            else
            {
                this.textBox1.Text = "Unsuccessful:" + newresponse.ErrorMessage + newresponse.ErrorException.Message;
            }

            return theProgress;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
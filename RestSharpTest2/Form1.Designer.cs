namespace RestSharpTest2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxServerPrefix = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelActualURLUsed = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSID = new System.Windows.Forms.Label();
            this.buttonDoSomething = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSSInfo = new System.Windows.Forms.Button();
            this.listBoxCameras = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLoadVideo = new System.Windows.Forms.Button();
            this.buttonPlayRecording = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(748, 103);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxServerPrefix
            // 
            this.textBoxServerPrefix.Location = new System.Drawing.Point(20, 15);
            this.textBoxServerPrefix.Name = "textBoxServerPrefix";
            this.textBoxServerPrefix.Size = new System.Drawing.Size(100, 23);
            this.textBoxServerPrefix.TabIndex = 1;
            this.textBoxServerPrefix.Text = "a113";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(207, 15);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Login";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelActualURLUsed
            // 
            this.labelActualURLUsed.AutoSize = true;
            this.labelActualURLUsed.Location = new System.Drawing.Point(22, 48);
            this.labelActualURLUsed.Name = "labelActualURLUsed";
            this.labelActualURLUsed.Size = new System.Drawing.Size(115, 15);
            this.labelActualURLUsed.TabIndex = 3;
            this.labelActualURLUsed.Text = "labelActualURLUSED";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(126, 15);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "LABEL1";
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Location = new System.Drawing.Point(62, 596);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(75, 15);
            this.labelSID.TabIndex = 6;
            this.labelSID.Text = "I am labelSID";
            // 
            // buttonDoSomething
            // 
            this.buttonDoSomething.Location = new System.Drawing.Point(360, 15);
            this.buttonDoSomething.Name = "buttonDoSomething";
            this.buttonDoSomething.Size = new System.Drawing.Size(89, 23);
            this.buttonDoSomething.TabIndex = 7;
            this.buttonDoSomething.Text = "List Cameras";
            this.buttonDoSomething.UseVisualStyleBackColor = true;
            this.buttonDoSomething.Click += new System.EventHandler(this.buttonDoSomething_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(455, 15);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(66, 23);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 201);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(748, 71);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "SID:";
            // 
            // buttonSSInfo
            // 
            this.buttonSSInfo.Location = new System.Drawing.Point(288, 15);
            this.buttonSSInfo.Name = "buttonSSInfo";
            this.buttonSSInfo.Size = new System.Drawing.Size(66, 23);
            this.buttonSSInfo.TabIndex = 11;
            this.buttonSSInfo.Text = "SS Info";
            this.buttonSSInfo.UseVisualStyleBackColor = true;
            this.buttonSSInfo.Click += new System.EventHandler(this.buttonSSInfo_Click);
            // 
            // listBoxCameras
            // 
            this.listBoxCameras.FormattingEnabled = true;
            this.listBoxCameras.ItemHeight = 15;
            this.listBoxCameras.Location = new System.Drawing.Point(20, 278);
            this.listBoxCameras.Name = "listBoxCameras";
            this.listBoxCameras.Size = new System.Drawing.Size(120, 94);
            this.listBoxCameras.TabIndex = 13;
            this.listBoxCameras.SelectedIndexChanged += new System.EventHandler(this.listBoxCameras_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonLoadVideo
            // 
            this.buttonLoadVideo.Location = new System.Drawing.Point(207, 489);
            this.buttonLoadVideo.Name = "buttonLoadVideo";
            this.buttonLoadVideo.Size = new System.Drawing.Size(91, 26);
            this.buttonLoadVideo.TabIndex = 16;
            this.buttonLoadVideo.Text = "Export Video";
            this.buttonLoadVideo.UseVisualStyleBackColor = true;
            this.buttonLoadVideo.Click += new System.EventHandler(this.buttonLoadVideo_Click);
            // 
            // buttonPlayRecording
            // 
            this.buttonPlayRecording.Location = new System.Drawing.Point(420, 489);
            this.buttonPlayRecording.Name = "buttonPlayRecording";
            this.buttonPlayRecording.Size = new System.Drawing.Size(117, 26);
            this.buttonPlayRecording.TabIndex = 17;
            this.buttonPlayRecording.Text = "Play Recording";
            this.buttonPlayRecording.UseVisualStyleBackColor = true;
            this.buttonPlayRecording.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 620);
            this.Controls.Add(this.buttonPlayRecording);
            this.Controls.Add(this.buttonLoadVideo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxCameras);
            this.Controls.Add(this.buttonSSInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonDoSomething);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelActualURLUsed);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxServerPrefix);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxServerPrefix;
        private Button buttonGo;
        private Label labelActualURLUsed;
        private Button buttonInfo;
        private Label label1;
        private Label labelSID;
        private Button buttonDoSomething;
        private Button buttonLogout;
        private TextBox textBox2;
        private Label label2;
        private Button buttonSSInfo;
        private ListBox listBoxCameras;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button buttonLoadVideo;
        private Button buttonPlayRecording;
    }
}
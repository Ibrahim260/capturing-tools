using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScreenRecorder
{
    public partial class screen_recorder : Form
    {
        // Filing variables:
        bool folderSelected = false;
        string outputPath = "";
        string finalVideoName = "FinalVideo.mp4";

        // Screen recorder object:
        VideoRecorder videoRecorder = new VideoRecorder(new Rectangle(), "");

        public screen_recorder()
        {
            InitializeComponent();
        }



        private void audioRecordLabel_Click(object sender, EventArgs e)
        {

        }

        private void recordCloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            //Create output path:
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select an Output Folder";

            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputPath = folderBrowser.SelectedPath;
                folderSelected = true;

                //Finish screen recorder object:
                Rectangle bounds = Screen.FromControl(this).Bounds;
                videoRecorder = new VideoRecorder(bounds, outputPath);
            }
            else
            {
                MessageBox.Show("Please select an output folder.", "Error");
            }
        }

        private void btnScreenRecord_Click(object sender, EventArgs e)
        {
          
            if (folderSelected)
            {
                tmrRecord.Start();
            }

            else
            {
                MessageBox.Show("and you must select an output folder before recording", "Error");
            }
        }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            videoRecorder.RecordVideo();
            videoRecorder.RecordAudio();
            timerLabel.Text = videoRecorder.GetElapsed();
        }


        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            tmrRecord.Stop();
            videoRecorder.Stop();
            Application.Restart();
        }
    }
}

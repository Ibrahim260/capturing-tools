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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath objectGrapics = new System.Drawing.Drawing2D.GraphicsPath();
            objectGrapics.AddEllipse(new Rectangle(0, 0, this.Width, this.Height));
            this.Region = new Region(objectGrapics);


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void audioRecordButton_Click(object sender, EventArgs e)
        {
            AudioRecord audioRecord = new AudioRecord();
            audioRecord.Show();
        }


        private void videoRecordButton_Click(object sender, EventArgs e)
        {
            screen_recorder screen_Recorder = new screen_recorder();
            screen_Recorder.Show();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ScreenRecorder
{
    public partial class AudioRecord : Form
    {
        public AudioRecord()
        {
            InitializeComponent();
            //record("open new Type waveaudio alias recsound", null, 0, IntPtr.Zero);
        }

        //[DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        //private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void audioCloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            //record("Open new type waveaudio Alias recSound ", " " , 0, 0);
            //record("record recSound", " " , 0, 0);
            //timer1.Enabled = true;
            //timer1.Start();
            //count.Start();
            //recordLabel.Text = "REC...";
            

        }

        //System.Diagnostics.Stopwatch count = new System.Diagnostics.Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimeSpan elapsed = count.Elapsed;
            //timerLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            //timer1.Enabled = false;
            //count.Stop();
            //record("pause recSound e:\\audio.wav", " " , 0, 0);
            //record("record recSound", " ", 0, 0);
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            ////saveFileDialog.Filter = ".wav";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    mciSendString("saveSound", null, 0, IntPtr.Zero);
            //    mciSendString("closeSound", null, 0, IntPtr.Zero);
            //}
            
            //recordLabel.Text = "RECORDED";
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //if (record == "")
            //{
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.Filter = ".wav";
            //    if (openFileDialog.ShowDialog() == DialogResult.OK )
            //    {
            //        record = openFileDialog.FileName;
            //    }
            //}
            //mciSendString("play" + record, null, 0, 0);
            
            //(new Microsoft.VisualBasic.Devices.Audio()).Play("e:\\audio.wav");
            //timer1.Start();
            //count.Reset();
            //count.Start();
            //recordLabel.Text = "PLAYING...";
        }
    }
}

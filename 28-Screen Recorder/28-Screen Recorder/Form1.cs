using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;
//using MetroFramework.Forms;

namespace _28_Screen_Recorder
{
    public partial class Form1 : Form
    {
        private ScreenCaptureJob gotu;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartRecord();
        }

        void StartRecord()
        {
            gotu = new ScreenCaptureJob();

            System.Drawing.Size WorkingArea = SystemInformation.WorkingArea.Size;
            Rectangle captureRect = new Rectangle(0, 0, WorkingArea.Width - (WorkingArea.Width % 4), WorkingArea.Height-(WorkingArea.Height%4));

            gotu.CaptureRectangle = captureRect;
            gotu.ShowFlashingBoundary = true;
            gotu.ShowCountdown = true;
            gotu.CaptureMouseCursor = true;
            gotu.AddAudioDeviceSource(AudioDevices());
            gotu.OutputPath = @"C:\Users\leo_n\Videos\video";

            try
            {
                gotu.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        EncoderDevice AudioDevices()
        {
            EncoderDevice foundDevice = null;
            Collection<EncoderDevice> audioDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);

            try
            {
                foundDevice = audioDevices.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Audio devices not found!\n\n" + ex.Message);
            }

            return foundDevice;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (gotu.Status == RecordStatus.Running)
            {
                gotu.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gotu.Status == RecordStatus.Running)
                gotu.Stop();
            gotu.Dispose();
        }
    }
}

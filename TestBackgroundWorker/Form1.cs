using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cancel_Button.Enabled = false;
        }
        
        private void Start_Button_Click(object sender, EventArgs ea)
        {
            Start_Button.Enabled = false;
            Cancel_Button.Enabled = true;
            backgroundCounter.RunWorkerAsync();
        }

        private int counter(BackgroundWorker bw, DoWorkEventArgs ea)
        {
            int result = 21;
            for (int i = 0; i <= 10; i++)
            {
                result += i;
                System.Threading.Thread.Sleep(100);
            }

            return result;
        }

        private void Cancel_Button_Click(object sender, EventArgs ea)
        {
            Result_Label.Text = "Canceled";
            progressBar1.Value = 0;
            Progress_Label.Text = "Press start...";
            Cancel_Button.Enabled = false;
            Start_Button.Enabled = true;
        }

        private void backgroundCounter_DoWork(object sender, DoWorkEventArgs ea)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            ea.Result = counter(bw, ea);
        }

        private void backgroundCounter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs ea)
        {

        }
    }
}

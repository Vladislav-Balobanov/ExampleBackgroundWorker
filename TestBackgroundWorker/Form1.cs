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

            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundCounter.DoWork +=
                new DoWorkEventHandler(backgroundCounter_DoWork);
            backgroundCounter.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundCounter_RunWorkerCompleted);
            backgroundCounter.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundCounter_ProgressChanged);
        }
        
        private void Start_Button_Click(object sender, EventArgs ea)
        {
            Start_Button.Enabled = false;
            backgroundCounter.RunWorkerAsync();
            pd.ShowDialog();
        }

        private int counter(BackgroundWorker bw, DoWorkEventArgs ea)
        {
            int result = 21;
            for (int i = 0; i <= 10; i++)
            {
                result += i;
                bw.ReportProgress(i*10, "Progress status " + (i*10));
            }

            return result;
        }

        public void Cancel()
        {
            backgroundCounter.CancelAsync();
            Result_Label.Text = "Canceled";
            Progress_Label.Text = "Press start...";
            Start_Button.Enabled = true;
        }

        private void backgroundCounter_DoWork(object sender, DoWorkEventArgs ea)
        {
            ea.Result = counter(backgroundCounter, ea);
        }

        private void backgroundCounter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs ea)
        {
            // First, handle the case where an exception was thrown.
            if (ea.Error != null)
            {
                MessageBox.Show(ea.Error.Message);
            }
            else if (ea.Cancelled)
            {
                Result_Label.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                Result_Label.Text = ea.Result.ToString();
            }
        }
        private void backgroundCounter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pd.ProgressIncrease(e.ProgressPercentage);
            Progress_Label.Text = (e.UserState).ToString();
        }
    }
}

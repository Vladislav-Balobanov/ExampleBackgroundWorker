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
        
        private void Start_Button_Click(object sender, EventArgs e)
        {
            Start_Button.Enabled = false;
            Cancel_Button.Enabled = true;
            int result = 21;
            for (int i = 0; i <= 10; i++)
            {
                progressBar1.Value = (i*10);
                result += i;
                System.Threading.Thread.Sleep(100);
                Progress_Label.Text = string.Empty;
                Progress_Label.Text = (i * 10).ToString() + " %";
            }
            Result_Label.Text = result.ToString();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Result_Label.Text = "Canceled";
            progressBar1.Value = 0;
            Progress_Label.Text = "Press start...";
            Cancel_Button.Enabled = false;
            Start_Button.Enabled = true;
        }
    }
}

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
    public partial class ProgressDilog : Form
    {
        public ProgressDilog()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            
        }

        public void ProgressIncrease(int increaseValue)
        {
            ProgressDialog_PB.Value = increaseValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Demo : Form
    {

        private ThreadStart threadStart;
        private Thread thread;
        public Demo()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            threadStart = new ThreadStart(Count);
            thread = new Thread(threadStart);
            thread.Start();

        }

        public void Count()
        {
            for (int i = 0; i <= Convert.ToInt32(txtCount.Text); i++)
            {
                lbOutput.Text = i.ToString();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}

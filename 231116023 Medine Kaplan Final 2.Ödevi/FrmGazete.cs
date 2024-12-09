using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116023_Medine_Kaplan_Final_2.Ödevi
{
    public partial class FrmGazete : Form
    {
        public FrmGazete()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate  ("https://www.haberturk.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }
    }
}

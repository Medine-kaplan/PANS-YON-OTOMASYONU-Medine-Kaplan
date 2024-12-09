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
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       axWindowsMediaPlayer1.URL = "https://vofile.ru/turkey/arabesk_damar_fm/icecast.audio";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           axWindowsMediaPlayer1.URL = "https://www.youtube.com/watch?v=clRdYNQNSnI";
        }
    }
}

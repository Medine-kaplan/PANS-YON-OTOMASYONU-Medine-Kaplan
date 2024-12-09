using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace _231116023_Medine_Kaplan_Final_2.Ödevi
{
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaplan Pansiyon Kayıt Uygulaması/2024-Muş");
        }

        private void FormAnaForm_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr = new FrmRadyoDinle();
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGazete fr = new FrmGazete();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelleme fr = new FrmSifreGuncelleme();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajalr fr = new FrmMesajalr();
            fr.Show();
        }
    }
}

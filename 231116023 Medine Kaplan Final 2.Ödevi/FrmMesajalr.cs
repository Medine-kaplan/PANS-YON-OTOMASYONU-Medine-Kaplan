using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using DevExpress.XtraBars.Painters;

namespace _231116023_Medine_Kaplan_Final_2.Ödevi
{
    public partial class FrmMesajalr : Form
    {
        public FrmMesajalr()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj)values(@adsoyad,@mesaj)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            komut.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görüş ve önerileriniz bizim için çok önemlidir teşekkürler.");
            verilerigoster();
        }

        private void FrmMesajalr_Load(object sender, EventArgs e)
        {
            verilerigoster();

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text= listView1.SelectedItems[0].SubItems[2].Text;

        }
    }
}

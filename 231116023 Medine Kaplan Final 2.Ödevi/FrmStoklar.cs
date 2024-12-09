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

namespace _231116023_Medine_Kaplan_Final_2.Ödevi
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True");
        private void veriler ()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,Icecek,Cerezler)values(@gida,@icecek,@cerez)", baglanti);
            komut.Parameters.AddWithValue("@gida", txtgıda.Text);
            komut.Parameters.AddWithValue("@icecek",Txticecek.Text);
            komut.Parameters.AddWithValue("@cerez", txtatıstırmalık.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler2();
            veriler();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet)values(@elektrik,@su,@internet)", baglanti);
            komut2.Parameters.AddWithValue("@elektrik", txtelektrik.Text);
            komut2.Parameters.AddWithValue("@su", txtsu.Text);
            komut2.Parameters.AddWithValue("@internet", txtinternet.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}

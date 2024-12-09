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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True");

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ücret)as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            //gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida)as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
               lblalınanurunler1.Text = oku2["toplam2"].ToString();

            }
            baglanti.Close();


            //İçecekler
            baglanti.Open();
            SqlCommand komut3= new SqlCommand("Select sum(Icecek)as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblalınanurunler2.Text = oku3["toplam3"].ToString();

            }
            baglanti.Close();


            //Çerezler
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler)as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblalınanurunler3.Text = oku4["toplam4"].ToString();

            }
            baglanti.Close();
            //ELEKTRİK
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik)as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblfaturalar1.Text = oku5["toplam5"].ToString();

            }
            baglanti.Close();
            //su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su)as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblfaturalar2.Text = oku6["toplam6"].ToString();

            }
            baglanti.Close();
            //İnternet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Internet)as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblfaturalar3.Text = oku7["toplam7"].ToString();

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text = (personel * 1500).ToString();



            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(lblpersonelmaas.Text) + Convert.ToInt32(lblalınanurunler1.Text) + Convert.ToInt32(lblalınanurunler2.Text) + Convert.ToInt32(lblalınanurunler3.Text) + Convert.ToInt32(lblfaturalar1.Text) + Convert.ToInt32(lblfaturalar2.Text) + Convert.ToInt32(lblfaturalar3.Text));
            lblsonuc.Text = sonuc.ToString();
        }
    }
}

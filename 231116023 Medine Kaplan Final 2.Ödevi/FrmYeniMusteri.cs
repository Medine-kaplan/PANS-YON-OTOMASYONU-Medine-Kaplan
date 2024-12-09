using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Animation;
using System.Data.SqlClient;
using System.Data.Sql;

namespace _231116023_Medine_Kaplan_Final_2.Ödevi
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True ");
        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into oda101 (Adi,Soyadi)values('"+TxtAdi.Text+"','"+TxtSoyad.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda102 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda103 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda104 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda105 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda106 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda107 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda108 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda109 (Adi,Soyadi)values('" + TxtAdi.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);


            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;
            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 250;
            TxtUcret.Text = ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ücret,GirisTarihi,CikisTarihi)values(@Adi,@Soyadi,@Cinsiyet,@Telefon,@Mail,@TC,@OdaNo,@Ücret,@GirisTarihi,@CikisTarihi)", baglanti);
            komut.Parameters.AddWithValue("@Adi",TxtAdi.Text);
            komut.Parameters.AddWithValue("@Soyadi", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", MskTelefon.Text);
            komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
            komut.Parameters.AddWithValue("@TC", TxtTCno.Text);
            komut.Parameters.AddWithValue("@OdaNo",TxtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ücret", TxtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select*from oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn101.Text != "101")
            {
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;

            }
            //102 nolu oda
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select*from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;

            }

            //103 nolu oda
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select*from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;

            }

            //104 nolu oda
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select*from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;

            }

            //105 nolu oda
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select*from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                Btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn105.Text != "105")
            {
             
             Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;

            }


            //106 nolu oda
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select*from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn106.Text != "106")
            {
                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;

            }

            //107 nolu oda
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select*from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                Btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn107.Text != "107")
            {
                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;

            }

            //108 nolu oda

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select*from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                Btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn108.Text != "108")
            {
                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }

            //109 nolu oda
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select*from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                Btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btn109.Text != "109")
            {
                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
        //Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True;
        // SqlCommand komut=new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);

    }
}

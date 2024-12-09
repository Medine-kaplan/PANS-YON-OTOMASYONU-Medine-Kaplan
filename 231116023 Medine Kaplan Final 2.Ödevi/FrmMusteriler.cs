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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True");


        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text= oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add( oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text= listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text= listView1.SelectedItems[0].SubItems[2].Text;
            cmbcinsiyet.Text= listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefon.Text=listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text=listView1.SelectedItems[0].SubItems[5].Text;
            TxtTCno.Text= listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text= listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text= listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text=listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',soyadi='" + TxtSoyad.Text + "',cinsiyet='" + cmbcinsiyet.Text + "',telefon='" + MskTelefon.Text + "',mail='"+TxtMail.Text+"',kimlik='"+TxtTCno.Text+"',OdaNo='"+TxtOdaNo.Text+"',ucret='"+TxtUcret.Text+"',giriştarihi='"+DtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"',çıkıştarihi='"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"' where Musteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text=="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyad.Clear();
            cmbcinsiyet.Text = "";
            MskTelefon.Clear();
            TxtMail.Text = "";
            TxtTCno.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpCikisTarihi.Text = "";
            DtpGirisTarihi.Text = "";
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from MusteriEkle where Adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
        //Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True;
    }
}

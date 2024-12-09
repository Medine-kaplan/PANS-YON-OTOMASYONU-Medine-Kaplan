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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True ");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select*from AdminGiris where Kulanici=@kullaniciadi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    FormAnaForm fr = new FormAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

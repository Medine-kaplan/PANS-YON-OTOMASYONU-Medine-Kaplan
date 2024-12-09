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
    public partial class FrmSifreGuncelleme : Form
    {
        public FrmSifreGuncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1PHU0I3;Initial Catalog=kaplanpansiyon;Integrated Security=True");

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("UpdateAdminGiris set kulanici='"+TxtKullaniciAdi.Text+"',Sifre='"+TxtSifre.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}

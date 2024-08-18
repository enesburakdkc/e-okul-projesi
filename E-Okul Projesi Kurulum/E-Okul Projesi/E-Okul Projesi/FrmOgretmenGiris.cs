using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Okul_Projesi
{
    public partial class FrmOgretmenGiris : Form
    {
        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Ogretmen where OgretmenTC = @p1 and OgretmenSifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmenDetay frmOgretmenDetay = new FrmOgretmenDetay();
                frmOgretmenDetay.OgretmenTC = MskTC.Text;
                frmOgretmenDetay.Show();
                this.Hide();
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOgretmenGiris_Load(object sender, EventArgs e)
        {

        }

        private void LnkLblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdminGiris frmAdminGiris = new FrmAdminGiris();
            frmAdminGiris.Show();
            this.Hide();
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

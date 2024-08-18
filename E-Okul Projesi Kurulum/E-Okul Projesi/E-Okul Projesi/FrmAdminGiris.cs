using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Okul_Projesi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }

        Baglanti bgl = new Baglanti();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Admin where AdminTC = @p1 and AdminSifre = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskAdminTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdminSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAdminDetay frmAdminDetay = new FrmAdminDetay();
                frmAdminDetay.AdminTC = MskAdminTC.Text;
                frmAdminDetay.Show();
                this.Hide();
                bgl.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris frmOgretmenGiris = new FrmOgretmenGiris();
            frmOgretmenGiris.Show();
            this.Hide();
        }
    }
}

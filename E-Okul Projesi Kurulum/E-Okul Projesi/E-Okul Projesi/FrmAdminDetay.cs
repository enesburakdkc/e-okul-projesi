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
    public partial class FrmAdminDetay : Form
    {
        public FrmAdminDetay()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        public string AdminTC;

        private void FrmAdminDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = AdminTC;

            SqlCommand komut = new SqlCommand("select * from Tbl_Admin where AdminTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[2].ToString();
                LblSoyad.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnOgretmenEkleAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminOgretmenEkle frmAdminOgretmenEkle = new FrmAdminOgretmenEkle();
            frmAdminOgretmenEkle.Show();
        }

        private void BtnOgrenciEkleAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminOgrenciEkle frmAdminOgrenciEkle = new FrmAdminOgrenciEkle();
            frmAdminOgrenciEkle.Show();
        }

        private void BtnGirisEkran_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

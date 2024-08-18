using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace E_Okul_Projesi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        Baglanti bgl = new Baglanti();

        public string OgretmenTC;

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = OgretmenTC;

            SqlCommand komut = new SqlCommand("select * from Tbl_Ogretmen where OgretmenTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[1].ToString();
                LblSoyad.Text = dr[2].ToString();
                LblBrans.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnDevamsizlikOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenDevamsizlik frmOgretmenDevamsizlik = new FrmOgretmenDevamsizlik();
            frmOgretmenDevamsizlik.Show();
        }

        private void BtnSonuclarOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenSınav frmOgretmenSınav = new FrmOgretmenSınav();
            frmOgretmenSınav.Brans = LblBrans.Text;
            frmOgretmenSınav.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnDuyuruOgretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmenDuyuru frmOgretmenDuyuru = new FrmOgretmenDuyuru();
            frmOgretmenDuyuru.DyrTC = LblTC.Text;
            frmOgretmenDuyuru.DyrYapan = LblAd.Text + " " + LblSoyad.Text;
            frmOgretmenDuyuru.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

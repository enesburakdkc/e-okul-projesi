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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string OgrenciTC;

        Baglanti bgl = new Baglanti();
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = OgrenciTC;

            SqlCommand komut = new SqlCommand("select * from Tbl_Ogrenci where OgrenciTC = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[2].ToString();
                LblSoyad.Text = dr[3].ToString();
                LblNumara.Text = dr[1].ToString();
                LblSinif.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnDevamsizlik_Click(object sender, EventArgs e)
        {
            FrmOgrenciDevamsızlik frmOgrenciDevamsızlik = new FrmOgrenciDevamsızlik();
            frmOgrenciDevamsızlik.DvmszlkTC = LblTC.Text;
            frmOgrenciDevamsızlik.Show();
        }

        private void BtnSonuclar_Click(object sender, EventArgs e)
        {
            FrmOgrenciSonuc frmOgrenciSonuc = new FrmOgrenciSonuc();
            frmOgrenciSonuc.SncTC = LblTC.Text;
            frmOgrenciSonuc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgrenciDuyuru frmOgrenciDuyuru = new FrmOgrenciDuyuru();
            frmOgrenciDuyuru.Show();
        }

        private void BtnGirisEkran_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

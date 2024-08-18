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
    public partial class FrmOgretmenDevamsizlik : Form
    {
        public FrmOgretmenDevamsizlik()
        {
            InitializeComponent();
        }

        Baglanti bgl= new Baglanti();

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgrenciAd, OgrenciSoyad, OgrenciTC from Tbl_Ogrenci where OgrenciNo = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[0].ToString();
                LblSoyad.Text = dr[1].ToString();
                LblTC.Text = dr[2].ToString();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select DevamsizlikTarihi as [Devamsızlık Tarihi], DevamsizlikTuru as [Devamsızlık Türü] from Tbl_Devamsizlik where DevamsizlikTC = '" + LblTC.Text + "'", bgl.baglanti());
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                bgl.baglanti().Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            MskTarih.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            CmbTur.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Devamsizlik where DevamsizlikTC = @p1 and DevamsizlikTarihi = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", MskTarih.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Devamsızlık silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Tablonun yenilenmesi için.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DevamsizlikTarihi as [Devamsızlık Tarihi], DevamsizlikTuru as [Devamsızlık Türü] from Tbl_Devamsizlik where DevamsizlikTC = '" + LblTC.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Devamsizlik (DevamsizlikTC, DevamsizlikTarihi, DevamsizlikTuru) values (@p1, @p2, @p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", MskTarih.Text);
            komut.Parameters.AddWithValue("@p3", CmbTur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Devamsızlık eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Tablonun yenilenmesi için.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DevamsizlikTarihi as [Devamsızlık Tarihi], DevamsizlikTuru as [Devamsızlık Türü] from Tbl_Devamsizlik where DevamsizlikTC = '" + LblTC.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmOgretmenDevamsizlik_Load(object sender, EventArgs e)
        {

        }
    }
}

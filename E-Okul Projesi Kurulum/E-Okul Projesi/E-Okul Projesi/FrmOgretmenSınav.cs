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
    public partial class FrmOgretmenSınav : Form
    {
        public FrmOgretmenSınav()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        public string Brans;

        internal void Yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ders, [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi] = ([1.Donem 1.Sinav] + [1.Donem 1.Sozlu] + [1.Donem 2.Sinav] + [1.Donem 2.Sozlu]) / 4, [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi] = ([2.Donem 1.Sinav] + [2.Donem 1.Sozlu] + [2.Donem 2.Sinav] + [2.Donem 2.Sozlu]) / 4 from Tbl_Sonuc where [Sonuc TC] = '" + LblTC.Text + "' and Ders = '" + Brans + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmOgretmenSınav_Load(object sender, EventArgs e)
        {
            
        }

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

                Yenile();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [" + CmbTur.Text + "] = NULL where [Sonuc TC] = @p1 and Ders = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", Brans);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Yenile();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            if (CmbTur.Text == "1.Donem 1.Sinav")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [1.Donem 1.Sinav] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "1.Donem 1.Sozlu")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [1.Donem 1.Sozlu] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "1.Donem 2.Sinav")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [1.Donem 2.Sinav] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "1.Donem 2.Sozlu")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [1.Donem 2.Sozlu] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "2.Donem 1.Sinav")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [2.Donem 1.Sinav] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "2.Donem 1.Sozlu")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [2.Donem 1.Sozlu] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "2.Donem 2.Sinav")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [2.Donem 2.Sinav] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else if (CmbTur.Text == "2.Donem 2.Sozlu")
            {
                SqlCommand komut = new SqlCommand("update Tbl_Sonuc set [2.Donem 2.Sozlu] = @p1 where [Sonuc TC] = @p2 and Ders = @p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPuan.Text);
                komut.Parameters.AddWithValue("@p2", LblTC.Text);
                komut.Parameters.AddWithValue("@p3", Brans);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtPuan.Text = dataGridView2.SelectedCells[0].Value.ToString();
            CmbTur.Text = dataGridView2.SelectedCells[0].OwningColumn.ToString();    //Başlık seçilmeli!
        }
    }
}

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
    public partial class FrmAdminOgrenciEkle : Form
    {
        public FrmAdminOgrenciEkle()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        private void FrmAdminOgrenciEkle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogrenci", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenci (OgrenciNo, OgrenciAd, OgrenciSoyad, OgrenciSinif, OgrenciCinsiyet, OgrenciTC) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskSinif.Text);
            komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Table'ı refreshlemek için
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogrenci", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();

            //Öğrenci oluşturuluduğunda o öğrenciye ait her sonuc bransından değer oluşturulmalı.
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", MskTC.Text);
            komut2.Parameters.AddWithValue("@d2", "Turk Dili ve Edebiyati");
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1", MskTC.Text);
            komut3.Parameters.AddWithValue("@d2", "Matematik");
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@d1", MskTC.Text);
            komut4.Parameters.AddWithValue("@d2", "Tarih");
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut5 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut5.Parameters.AddWithValue("@d1", MskTC.Text);
            komut5.Parameters.AddWithValue("@d2", "Cografya");
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut6 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut6.Parameters.AddWithValue("@d1", MskTC.Text);
            komut6.Parameters.AddWithValue("@d2", "Felsefe");
            komut6.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut7 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut7.Parameters.AddWithValue("@d1", MskTC.Text);
            komut7.Parameters.AddWithValue("@d2", "Din Kulturu");
            komut7.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut8 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut8.Parameters.AddWithValue("@d1", MskTC.Text);
            komut8.Parameters.AddWithValue("@d2", "Ingilizce");
            komut8.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut9 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut9.Parameters.AddWithValue("@d1", MskTC.Text);
            komut9.Parameters.AddWithValue("@d2", "Biyoloji");
            komut9.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut10 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut10.Parameters.AddWithValue("@d1", MskTC.Text);
            komut10.Parameters.AddWithValue("@d2", "Fizik");
            komut10.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut11 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut11.Parameters.AddWithValue("@d1", MskTC.Text);
            komut11.Parameters.AddWithValue("@d2", "Kimya");
            komut11.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut12 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut12.Parameters.AddWithValue("@d1", MskTC.Text);
            komut12.Parameters.AddWithValue("@d2", "Beden Egitimi");
            komut12.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut13 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut13.Parameters.AddWithValue("@d1", MskTC.Text);
            komut13.Parameters.AddWithValue("@d2", "Muzik");
            komut13.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut14 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut14.Parameters.AddWithValue("@d1", MskTC.Text);
            komut14.Parameters.AddWithValue("@d2", "Gorsel Sanatlar");
            komut14.ExecuteNonQuery();
            bgl.baglanti().Close();
            SqlCommand komut15 = new SqlCommand("insert into Tbl_Sonuc ([Sonuc TC], Ders) values (@d1, @d2)", bgl.baglanti());
            komut15.Parameters.AddWithValue("@d1", MskTC.Text);
            komut15.Parameters.AddWithValue("@d2", "Rehberlik");
            komut15.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        string id;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            id = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            TxtNo.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            MskSinif.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            CmbCinsiyet.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            MskTC.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Ogrenci where OgrenciTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Table'ı refreshlemek için
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogrenci", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();

            //Öğrenci silindiğinde o öğrenciye ait sonuc değerleri silinmeli.
            SqlCommand komut2 = new SqlCommand("delete from Tbl_Sonuc where [Sonuc TC] = @d1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Öğrenciye ait devamsılzığın sillinmesi için.
            SqlCommand komut3 = new SqlCommand("delete from Tbl_Devamsizlik where DevamsizlikTC = @d1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1", MskTC.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}

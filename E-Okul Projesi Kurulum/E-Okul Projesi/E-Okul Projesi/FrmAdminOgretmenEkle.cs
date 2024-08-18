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
    public partial class FrmAdminOgretmenEkle : Form
    {
        public FrmAdminOgretmenEkle()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogretmen (OgretmenAd, OgretmenSoyad, OgretmenBrans, OgretmenCinsiyet, OgretmenTC, OgretmenSifre) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğretmen eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Tablonun Refresh edilmesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogretmen", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmAdminOgretmenEkle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogretmen", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        public string id;

        internal void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView2 tablosu üzerinde üstüne tıklanan hücredeki değerleri ekrana getirme.
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            id = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            CmbCinsiyet.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            MskTC.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            TxtSifre.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Ogretmen where OgretmenTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğretmen silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Silinen öğretmenin oluşturduğu duyurular da silinsin.
            SqlCommand komut2 = new SqlCommand("delete from Tbl_Duyuru where DuyuruTC = @p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Tablonun Refresh edilmesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Ogretmen", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}

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
    public partial class FrmOgretmenDuyuru : Form
    {
        public FrmOgretmenDuyuru()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        public string DyrTC;
        public string DyrYapan;

        internal void Yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DuyuruyuYapan as [Duyuruyu Yapan], DuyuruBaslik as [Duyuru Başlığı], DuyuruAciklama as [Duyuru Detay] from Tbl_Duyuru", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmOgretmenDuyuru_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void BtnPaylas_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyuru (DuyuruTC, DuyuruyuYapan, DuyuruBaslik, DuyuruAciklama) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DyrTC);
            komut.Parameters.AddWithValue("@p2", DyrYapan);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RchTxtDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru paylaşıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Yenile();
        }

        private void BtnKaldir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Duyuru where DuyuruBaslik = @p1 and DuyuruAciklama = @p2 and DuyuruTC = @p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p2", RchTxtDetay.Text);
            komut.Parameters.AddWithValue("@p3", DyrTC);
            int a = komut.ExecuteNonQuery();    //Etkilenen satır sayısını döndürür.
            if (a == 1)
            {
                MessageBox.Show("Duyuru silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
            }
            else
            {
                MessageBox.Show("Size ait olmayan veya daha önce silinmiş bir duyuruyu silemezsin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Yenile();
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBaslik.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            RchTxtDetay.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}

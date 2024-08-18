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
    public partial class FrmOgrenciDuyuru : Form
    {
        public FrmOgrenciDuyuru()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        private void FrmOgrenciDuyuru_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DuyuruyuYapan as [Duyuruyu Yapan], DuyuruBaslik as [Duyuru Başlığı], DuyuruAciklama as [Duyuru Detay] from Tbl_Duyuru", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}

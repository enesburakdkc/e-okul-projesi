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
    public partial class FrmOgrenciSonuc : Form
    {
        public FrmOgrenciSonuc()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        public string SncTC;

        private void FrmOgrenciSonuc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ders, [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi] = ([1.Donem 1.Sinav] + [1.Donem 1.Sozlu] + [1.Donem 2.Sinav] + [1.Donem 2.Sozlu]) / 4, [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi] = ([2.Donem 1.Sinav] + [2.Donem 1.Sozlu] + [2.Donem 2.Sinav] + [2.Donem 2.Sozlu]) / 4 from Tbl_Sonuc where [Sonuc TC] = '" + SncTC + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}

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
    public partial class FrmOgrenciDevamsızlik : Form
    {
        public FrmOgrenciDevamsızlik()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();

        public string DvmszlkTC;

        private void FrmOgrenciDevamsızlik_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select DevamsizlikTarihi as [Devamsızlık Tarihi], DevamsizlikTuru as [Devamsızlık Türü] from Tbl_Devamsizlik where DevamsizlikTC = '" + DvmszlkTC + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}

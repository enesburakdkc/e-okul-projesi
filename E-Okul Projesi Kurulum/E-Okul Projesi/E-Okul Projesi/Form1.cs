using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris frmOgrenciGiris = new FrmOgrenciGiris();
            frmOgrenciGiris.Show();
            this.Hide();
        }

        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris frmOgretmenGiris = new FrmOgretmenGiris();
            frmOgretmenGiris.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

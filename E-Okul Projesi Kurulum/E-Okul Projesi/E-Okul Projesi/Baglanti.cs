using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace E_Okul_Projesi
{
    public class Baglanti
    {
        public SqlConnection baglanti()
        {
            string dataBaseAdi = System.IO.File.ReadAllText(@"C:\DataBaseErisim.txt");
            SqlConnection baglan = new SqlConnection(dataBaseAdi);
            baglan.Open();
            return baglan;
        }

    }
}

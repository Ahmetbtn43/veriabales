using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=HastaneProje;integrated security=true");
            baglan.Open();
            return baglan;
        }
    }
}

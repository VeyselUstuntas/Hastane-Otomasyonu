using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _200707048_VeyselÜstüntaş_HastaneOtomasyonu
{
    class SQLConnection
    {
        public SqlConnection SQLBaglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=VEYSELUSTUNTAS;Initial Catalog=HastaneOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
//VeyselUstuntas
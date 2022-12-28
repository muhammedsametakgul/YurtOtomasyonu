using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Yurt
{
    internal class Sql
    {
        public SqlConnection Baglan() {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "YurtOtomasyonu.mdf;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        
        }
    }
}

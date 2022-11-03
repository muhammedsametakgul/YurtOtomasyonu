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
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-8PJ34AJ;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        
        }
    }
}

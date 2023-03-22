using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DZ_demka
{
    internal class DataBase
    {
        SqlConnection db_con = new SqlConnection(@"Data Source=DESKTOP-BBAJL13\SQLEXPRESS;Initial Catalog= DZ_Demka; Integrated Security=True");

        public void openConnection()
        {
            if (db_con.State == System.Data.ConnectionState.Closed)
            {
                db_con.Open();
            }
        }

        public void closeConnection()
        {
            if (db_con.State == System.Data.ConnectionState.Open)
            {
                db_con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return db_con;
        }
    }
}

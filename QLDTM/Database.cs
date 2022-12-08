using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDTM
{
    class Database
    {
        SqlConnection sqlcon;
        SqlDataAdapter da;
        DataSet ds;
        public Database(string srvname, string dbname)
        {
            string strcnn = "Data Source=" + srvname + ";Initial Catalog=" + dbname + ";Integrated Security=True";
            sqlcon = new SqlConnection(strcnn);
        }
        public DataTable Execute(string strsql)
        {
            da = new SqlDataAdapter(strsql, sqlcon);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExcuteNonQuery(string strsql)
        {
            SqlCommand sqlcm = new SqlCommand(strsql, sqlcon);
            sqlcon.Open();
            sqlcm.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}

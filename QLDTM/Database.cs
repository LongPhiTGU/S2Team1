using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLDTM
{
    class Database
    {
        SqlConnection sqlconn;
        SqlDataAdapter da;
        DataSet ds;
        public Database(string srvname, string dbName)
        {
            string cnnstr = "Data source=" + srvname + "; Initial Catalog=" + dbName + "; Integrated Security = true";
            sqlconn = new SqlConnection(cnnstr);
        }
        public DataTable Excute(string sqlstr)
        {
            da = new SqlDataAdapter(sqlstr, sqlconn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExcuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using QLDKHP1.DTO;
using System.Windows.Forms;

namespace QLDTM.DAO
{
    class SinhVienDAO
    {
        public static DataTable TT_BacHoc()
        {
            string sql = "select * from HeHoc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TT_SinhVien()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TT_NganhHoc()
        {
            string sql = "select * from NghanhHoc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TT_LopHoc()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}

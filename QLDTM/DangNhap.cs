using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLDTM
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            tbmsdn.Text = "Mã số đăng nhập";
            tbmk.Text = "Mật khẩu";         
            //thêm xóa sửa CSDL
            //BTLenh("INSERT[dbo].[DMKHOA]([MAKHOA], [TENKHOA]) VALUES(N'LT', N'NMLT')");
            //Show CSDL lên dgv
            //string strsql = "select * from Taikhoan";
            //SQLView(strsql);
        }
        public static SqlConnection cn = new SqlConnection();
        public static void MoSQL()
        {
            try
            {
                string sqlcon = @"Data Source=DESKTOP-NKRR2R8;Initial Catalog=QLDT;Integrated Security=True";
                cn.ConnectionString = sqlcon;
                if (cn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Thành công!");
                    cn.Open();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối CSDLthất bại!");
                Environment.Exit(0);
            }
        }
        public static void TatSQL()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        // select
        public DataTable SQLView(string strsql)
        {
            string sqlconsqlcon = @"Data Source=DESKTOP-NKRR2R8;Initial Catalog=QLDT;Integrated Security=True";
            cn.ConnectionString = sqlconsqlcon;
            SqlDataAdapter da = new SqlDataAdapter(strsql, sqlconsqlcon);
            DataSet ds = new DataSet();
            da.Fill(ds);
            TatSQL();
            return ds.Tables[0];          
        }
        //câu khai báo cho lệnh update, insert, delete
        public void BTLenh(string sql)
        {
            MoSQL();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            TatSQL();
        }

        private void tbmsdn_TextChanged(object sender, EventArgs e)
        {          
        }

        private void tbmk_TextChanged(object sender, EventArgs e)
        {           
        }

        private void tbmsdn_Click(object sender, EventArgs e)
        {
            tbmsdn.Text = "";
            if(tbmk.Text=="")
                tbmk.Text = "Mật khẩu";
        }

        private void tbmk_Click(object sender, EventArgs e)
        {
            tbmk.Text = "";
            if (tbmsdn.Text=="")
                tbmsdn.Text = "Mã số đăng nhập";
        }

        private void btdn_Click(object sender, EventArgs e)
        {
            string strsql = "select * from Taikhoan";
            DataTable dt = SQLView(strsql);
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i][0].ToString() == tbmsdn.Text) && (dt.Rows[i][1].ToString()==tbmk.Text))
                    MessageBox.Show("Thành công");
            dataGridView1.DataSource = dt;
        }
    }
}

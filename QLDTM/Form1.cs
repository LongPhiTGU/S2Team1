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

namespace QLDTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
                textBox1.Text = "Mã số sinh viên";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
               // textBox2.Text = "Mật khẩu";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Mã số";
            textBox2.Text = "Mật khẩu";
            //thêm xóa sửa CSDL
            BTLenh("INSERT[dbo].[DMKHOA]([MAKHOA], [TENKHOA]) VALUES(N'LT', N'NMLT')");
            //Show CSDL
            string sqlconsqlcon = @"workstation id=Shopbook.mssql.somee.com;packet size=4096;user id=lehoang1111_SQLLogin_1;pwd=clkf61cvvp;data source=Shopbook.mssql.somee.com;persist security info=False;initial catalog=Shopbook"; 
            cn.ConnectionString=sqlconsqlcon;
            SqlDataAdapter da;
            DataSet ds;
            string strsql = "select * from DMKHOA";
            da = new SqlDataAdapter(strsql, sqlconsqlcon);
            ds = new DataSet();
            da.Fill(ds);
            
            DataTable dt = ds.Tables[0];
            TatSQL();
            
            
            dataGridView1.DataSource = dt;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mã số sinh viên")
                textBox1.Text = "";
            
        }
        public static SqlConnection cn = new SqlConnection();
        public static void MoSQL()
        {
            try
            {
                string sqlcon = @"workstation id=Shopbook.mssql.somee.com;packet size=4096;user id=lehoang1111_SQLLogin_1;pwd=clkf61cvvp;data source=Shopbook.mssql.somee.com;persist security info=False;initial catalog=Shopbook";
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

        //câu khai báo cho lệnh update, insert, delete
        public void BTLenh(string sql)
        {
            MoSQL();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            TatSQL();
            
        }

    }
}

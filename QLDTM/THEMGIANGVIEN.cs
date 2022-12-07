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
    public partial class THEMGIANGVIEN : Form
    {
        Database db;
        public THEMGIANGVIEN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
            QLGV QL = new QLGV();
            QL.Show();
        }
        public static SqlConnection cn = new SqlConnection();
        /*public static void MoSQL()
        {

            try
            {
                string sqlcon = @"Data Source=LAPTOP-988MUB58;Initial Catalog=QLSV10;Integrated Security=True";
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
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            //MoSQL();
            db = new Database(@"LAPTOP-988MUB58", "QLSV10");
            string sql = "insert into DMSV(MASV, TENSV) values('" + textBox1.Text + "', N'" + textBox2.Text + "')";
            MessageBox.Show(sql);
            
            db.ExcuteNonQuery(sql);
            QLGV ql = new QLGV();
            ql.Show();
            
           
            //SqlCommand cmd = new SqlCommand(sql, cn);
            //cmd.ExecuteNonQuery();
            //TatSQL();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void THEMGIANGVIEN_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class QLGV : Form
    {
        Database db;
        public QLGV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            THEMGIANGVIEN TH = new THEMGIANGVIEN();
            TH.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SUAGIANGVIEN S = new SUAGIANGVIEN();
            S.Show();
        }

        private void QLGV_Load(object sender, EventArgs e)
        {
            db = new Database(@"LAPTOP-988MUB58", "QLSV10");
            string sql = "Select * from DMSV";
            DataTable dt = db.Excute(sql);
            dataGridView1.DataSource = dt;
            
        }
       
      

       
}
}

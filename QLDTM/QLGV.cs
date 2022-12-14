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
        public string hienthihoten;
        public string hienthiemail;
        public string hienthimagv;
        public string suahoten;
        public string suaemail;
        public string suamagv;
        //private string message;

        public QLGV()
        {
            InitializeComponent();
           //this.dataGridView1.SelectionMode =
//DataGridViewSelectionMode.FullRowSelect;
        }
       // public QLGV(string them) : this()
        //{
         //   message = them;
         //   label1.Text = message;
        //}   

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "--Tất cả--")
            {
               // db = new Database(@"LAPTOP-988MUB58", "QLSV10");
                string sql = "Select * from DMSV";
                DataTable sqlmagv = db.Excute(sql);
                dataGridView1.DataSource = sqlmagv;
            }  
            else if (comboBox1.Text == "Mã giảng viên")
            {

                string sql1 = "select * FROM DMSV where Masv like '%" + textBox1.Text.Trim() + "%'";
                DataTable sqlmagv1 = db.Excute(sql1);              
                dataGridView1.DataSource = sqlmagv1;
            }
            else if (comboBox1.Text == "Tên giảng viên")
            {

                string sql1 = "select * FROM DMSV where tensv like N'%" + textBox1.Text.Trim() + "%'";
                DataTable sqlmagv1 = db.Excute(sql1);
                dataGridView1.DataSource = sqlmagv1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            THEMGIANGVIEN TH = new THEMGIANGVIEN();
            TH.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           SUAGIANGVIEN S = new SUAGIANGVIEN();
            S.suaHoten = suahoten;
            S.suaEmail = suaemail;
            S.suaMagv = suamagv;
            S.Show();
        }

        private void QLGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV10DataSet.DMSV' table. You can move, or remove it, as needed.
           this.dMSVTableAdapter.Fill(this.qLSV10DataSet.DMSV);
            // dataGridView1.Rows[0].Cells[1].Value.ToString() = magv;                     
            hienthi();
            comboBox1.Items.Add("--Tất cả--");
            comboBox1.Items.Add("Mã giảng viên");
            comboBox1.Items.Add("Tên giảng viên");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void hienthi()
        {
            db = new Database(@"LAPTOP-988MUB58", "QLSV10");
            string sql = "Select * from DMSV";
            DataTable dt = db.Execute(sql);
            dataGridView1.DataSource = dt;
          
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            THÔNGTINCHITIETGV F = new THÔNGTINCHITIETGV();
            F.hienthiHoten = hienthihoten;
            F.hienthiEmail = hienthiemail;
            F.hienthiMagv = hienthimagv;
            F.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            hienthihoten = dataGridView1.Rows[i].Cells[0].Value.ToString();
            suamagv = dataGridView1.Rows[i].Cells[0].Value.ToString();
            suahoten = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hienthi();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int j = dataGridView1.CurrentCell.RowIndex;
            //string sql = "select * FROM DMSV WHERE MaSV = '" + dataGridView1.Rows[j].Cells[0].Value.ToString() + "'";
            string Masv = Convert.ToString(dataGridView1.Rows[j].Cells[0].Value.ToString());
           // DataTable dt = db.Excute(sql);
           // for (int i = 0; i < dt.Rows.Count; i++)
           // {
                
               
               // MessageBox.Show(sql);
                string str;
                str = "Delete from DMSV where MaSV = '" + dataGridView1.Rows[j].Cells[0].Value.ToString() + "'";
                db.ExcuteNonQuery(str);
           // }
            MessageBox.Show("Đã xóa các môn chua học thành công");
            hienthi();
        }
    }
}

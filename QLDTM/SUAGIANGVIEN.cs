using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDTM
{
    public partial class SUAGIANGVIEN : Form
    {
        Database db;
        public string suaHoten;
        public string suaMagv;
        public string suaEmail;
        public SUAGIANGVIEN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SUAGIANGVIEN_Load(object sender, EventArgs e)
        {
            textBox1.Text = suaMagv;
            textBox2.Text = suaHoten;
            textBox3.Text = suaEmail;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new Database(@"LAPTOP-988MUB58", "QLSV10");
            string sql = "UPDATE DMSV set tensv= N'" + textBox2.Text + "' where Masv = N'" + textBox1.Text + "'";
            MessageBox.Show("Bạn đã cập nhật thông tin thành công");

            db.ExcuteNonQuery(sql);
        }
    }
}

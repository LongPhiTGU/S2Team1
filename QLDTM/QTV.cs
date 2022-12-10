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
    public partial class QTV : Form
    {
        public QTV()
        {
            InitializeComponent();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void QTV_Load(object sender, EventArgs e)
        {
            comboBox2.Visible= false;
            comboBox1.Items.Add("Chương trình đào tạo");
            comboBox1.Items.Add("Danh sách");
            comboBox1.Items.Add("Học phí/ Lệ phí");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Chương trình đào tạo")
            {
                comboBox2.Visible= true;
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Hệ đào tạo");
                comboBox2.Items.Add("Bậc đào tạo");
                comboBox2.Items.Add("Ngành");
                comboBox2.Items.Add("Khóa");
                comboBox2.Items.Add("Năm học");
                comboBox2.Items.Add("Học kì");
            }
            else if (comboBox1.Text == "Danh sách")
            {
                comboBox2.Visible = true;
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Đơn vị");
                comboBox2.Items.Add("Lớp học");
                comboBox2.Items.Add("Môn học");
                comboBox2.Items.Add("Giảng viên");
                comboBox2.Items.Add("Sinh viên");
            }
            else if (comboBox1.Text == "Học phí/ Lệ phí")
            {
                comboBox2.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

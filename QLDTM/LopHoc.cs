using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QLDTM.DAO;

namespace QLDTM
{
    public partial class LopHoc : Form
    {
        public LopHoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void TT_LopHoc()
        {
            DataTable dt = new DataTable();
            //dt = SinhVienDAO.TT_LopHoc();//sử dụng using .DAO để kết nối trong thư mục
            int solh = dt.Rows.Count;
            for (int i = 0; i < solh; i++)
            {
                listView1.Items.Add(dt.Rows[i]["maLop"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["mssv"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["tenLop"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["namhoc"].ToString());
            }
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            TT_LopHoc();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}

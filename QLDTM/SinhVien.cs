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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void TT_SV()
        {
            DataTable dt = new DataTable();
            //dt = SinhVienDAO.TT_SinhVien();
            int sosv = dt.Rows.Count;
            for (int i = 0; i < sosv; i++)
            {
                listView1.Items.Add(dt.Rows[i]["maSV"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["tenSV"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["ngaySinh"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["quequan"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["tamtru"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["gioiTinh"].ToString());
            }
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            TT_SV();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }
    }
}

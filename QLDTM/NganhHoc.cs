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
    public partial class NganhHoc : Form
    {
        public NganhHoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void TT_NghanhHoc()
        {
            DataTable dt = new DataTable();
            //dt = SinhVienDAO.TT_NganhHoc();
            int sonh = dt.Rows.Count;
            for (int i = 0; i < sonh; i++)
            {
                listView1.Items.Add(dt.Rows[i]["maNganh"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["maLop"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["tenNghanh"].ToString());
            }
        }

        private void NganhHoc_Load(object sender, EventArgs e)
        {
            TT_NghanhHoc();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}

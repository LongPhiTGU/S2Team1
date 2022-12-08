using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QLDKHP1.BUS;
using QLDTM.DAO;
//using QLDKHP1.DTO;

namespace QLDTM
{
    public partial class BacHoc : Form
    {
        public BacHoc()
        {
            InitializeComponent();
        }

        public void TT_BacHoc()
        {
            DataTable dt = new DataTable();
            dt = SinhVienDAO.TT_BacHoc();
            int sl = dt.Rows.Count;
            for (int i = 0; i < sl; i++)
            {
                listView1.Items.Add(dt.Rows[i]["maHe"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["tenHe"].ToString());

            }
        }

        private void BacHoc_Load(object sender, EventArgs e)
        {
            TT_BacHoc();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

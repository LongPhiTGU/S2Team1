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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tìmKiếmSinhVieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bậcHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BacHoc frm2 = new BacHoc();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhậpThôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien frm2 = new SinhVien();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }

        private void nghànhHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NganhHoc frm2 = new NganhHoc();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LopHoc frm2 = new LopHoc();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }
    }
}

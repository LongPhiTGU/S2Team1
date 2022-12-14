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
    public partial class DangNhapDN : Form
    {
        public DangNhapDN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void DangNhapDN_Load(object sender, EventArgs e)
        {
            Database db = new Database(@"DESKTOP-NKRR2R8", "QLDT");
            string sql = "Select * from Taikhoan";
            DataTable dt = db.Execute(sql);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database(@"DESKTOP-NKRR2R8", "QLDT");
            string sql = "Select * from Taikhoan";
            DataTable dt = db.Execute(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i][0].ToString() == tbmsdn.Text) && (dt.Rows[i][1].ToString() == tbmk.Text) && (dt.Rows[i][2].ToString() == "Admin"))
                {
                    MessageBox.Show("Thành công");
                    this.Hide();
                    QTV fr=new QTV();
                    fr.ShowDialog();
                    this.Close();
                }
                    
        }
    }
}

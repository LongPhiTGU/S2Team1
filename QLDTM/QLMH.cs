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
    public partial class QLMH : Form
    {
        Database db;
        public QLMH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            THEMMONHOC t = new THEMMONHOC();
            t.Show();
        }
        public void hienthi()
        {
            db = new Database(@"LAPTOP-988MUB58", "QLSV10");
            string sql = "Select * from DSLOP";
            DataTable dt = db.Excute(sql);
            dataGridView1.DataSource = dt;


        }

        private void QLMH_Load(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}

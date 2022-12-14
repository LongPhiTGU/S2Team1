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
    public partial class THEMMONHOC : Form
    {
        Database db;
        public THEMMONHOC()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void THEMMONHOC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new Database(@"LAPTOP-988MUB58", "QLSV10");
            string sql = "insert into DSLOP(MALOP, TENLOP) values('" + textBox1.Text + "', N'" + textBox2.Text + "')";
            MessageBox.Show(sql);

            db.ExcuteNonQuery(sql);
        }
    }
}

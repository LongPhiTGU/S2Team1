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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string pic = "1.jpg";
            if (textBox2.Text.Length > 3)
                pic = "2.jpg";
            if (textBox2.Text.Length > 6)
                pic = "3.jpg";
            if (textBox2.Text.Length > 9)
                pic = "4.jpg";
            if (textBox2.Text.Length > 12)
                pic = "5.jpg";
            pictureBox1.Load(pic);
        }
    }
}

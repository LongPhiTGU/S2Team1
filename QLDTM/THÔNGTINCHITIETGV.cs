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
    public partial class THÔNGTINCHITIETGV : Form
    {
        public string hienthiHoten;
        public string hienthiMagv;
        public string hienthiEmail;
        public THÔNGTINCHITIETGV()
        {
            InitializeComponent();
        }

        private void THÔNGTINCHITIETGV_Load(object sender, EventArgs e)
        {
            textBox1.Text = hienthiHoten;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

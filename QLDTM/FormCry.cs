using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONHOC
{
    public partial class FormCry : Form
    {
        public string mamh;
        public FormCry()
        {
            InitializeComponent();
        }

        private void FormCry_Load(object sender, EventArgs e)
        {
            Database db;
            db = new Database(@"DESKTOP-NKRR2R8", "QLSV");
            string sql = "select kq.MAMH,TENMH,kq.MASV, HOSV+' '+TENSV as HOTEN,case when PHAI=1 then N'Nữ' else N'NAM' end as GIOITINH,LANTHI,DIEM from KETQUA kq, DMSV sv, DMMH mh where sv.MASV=kq.MASV and kq.MAMH=mh.MAMH and mh.MAMH='"+mamh+"'";
            DataTable dt = db.Execute(sql);

            CrystalReport1 cry = new CrystalReport1();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}

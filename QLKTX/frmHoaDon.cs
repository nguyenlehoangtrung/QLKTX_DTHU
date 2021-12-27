using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLKTXDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLKTXDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLKTXDataSet.HOPDONG' table. You can move, or remove it, as needed.
            this.hOPDONGTableAdapter1.Fill(this.qLKTXDataSet.HOPDONG);
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportHD.HOPDONG' table. You can move, or remove it, as needed.
            this.HOPDONGTableAdapter.Fill(this.ReportHD.HOPDONG,cbo_tensv.Text);
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

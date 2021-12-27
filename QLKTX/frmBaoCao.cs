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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoCaoDataSet.HOPDONG' table. You can move, or remove it, as needed.
           

        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            this.HOPDONGTableAdapter.Fill(this.BaoCaoDataSet.HOPDONG, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEnd.Value.ToShortDateString()));
            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

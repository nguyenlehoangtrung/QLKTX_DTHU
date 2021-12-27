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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
        }

        private void tsmi_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }                
        }

        private void tsmi_ttsv_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.ShowDialog();
        }

        private void tsmi_phong_Click(object sender, EventArgs e)
        {
            frmPhong f = new frmPhong();
            f.ShowDialog();
        }

        private void tsmi_tthd_Click(object sender, EventArgs e)
        {
            frmHopDong f = new frmHopDong();
            f.ShowDialog();
        }

        private void tsmi_dangnhap_Click(object sender, EventArgs e)
        {      
            this.Close();
        }

        private void tsmi_thongke_Click(object sender, EventArgs e)
        {
            frmThongKeHD f = new frmThongKeHD();
            f.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            f.ShowDialog();
        }

        private void xuấtHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.ShowDialog();
        }

        private void tsmi_doimk_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mrTrung0789772018ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saoLưuVàKhôiPhụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBackupRestore f = new frmBackupRestore();
            f.ShowDialog();
        }
    }
}

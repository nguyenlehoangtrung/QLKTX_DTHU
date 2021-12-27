using QLKTX.BUS;
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
    public partial class frmDangNhap : Form
    {
        Dangnhap_BUS DNBUS = new Dangnhap_BUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txt_taikhoan.Text = Properties.Settings.Default.users;
            txt_matkhau.Text = Properties.Settings.Default.pass;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text;
            string password = txt_matkhau.Text;
            if(DNBUS.Login(username,password) == true)
            {
               // MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                frmTrangChu f = new frmTrangChu();
                f.ShowDialog();
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.users= txt_taikhoan.Text;
                    Properties.Settings.Default.pass = txt_matkhau.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.users = "";
                    Properties.Settings.Default.pass = "";
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

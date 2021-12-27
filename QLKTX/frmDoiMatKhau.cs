using QLKTX.BUS;
using QLKTX.DTO;
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
    public partial class frmDoiMatKhau : Form
    {
        Dangnhap_BUS DNBUS = new Dangnhap_BUS();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_pass_new.Text == ""|| txt_tendangnhap.Text == "" || txt_repass_new.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các trường");
            }
            else if (txt_tendangnhap.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cẩn đổi mật khẩu");
            }
            else if (txt_pass_new.Text != txt_repass_new.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhân không trùng khớp", "Thông báo");
            }
            else
            {
                string username = txt_tendangnhap.Text;
                if (DNBUS.check(username) == true)
                {
                    Dangnhap dn = new Dangnhap();
                    dn.TaiKhoan = txt_tendangnhap.Text;
                    dn.MatKhau = txt_pass_new.Text;
                    if (!DNBUS.Sua(dn))
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        txt_pass_new.Clear();
                        txt_repass_new.Clear();
                    }
                }
                else
                    MessageBox.Show("Sai tên tài khoản", "Thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

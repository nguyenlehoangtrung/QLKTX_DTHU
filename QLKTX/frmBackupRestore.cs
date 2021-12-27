using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKTX.BUS;

namespace QLKTX
{
    public partial class frmBackupRestore : Form
    {
        Thongke_BUS TKBUS = new Thongke_BUS();
        public frmBackupRestore()
        {
            InitializeComponent();
        }

        private void btn_filebk_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_backup.Text = dlg.SelectedPath;
                btn_backup.Enabled = true;
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {

            if (txt_backup.Text == string.Empty)
            {
                MessageBox.Show("chọn file");
            }
            else
            {
                TKBUS.Backup(txt_backup.Text);
                MessageBox.Show("Backup dữ liệu thành công");
                txt_backup.Clear();
                btn_backup.Enabled = false;
            }
        }

        private void btn_filers_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_restore.Text = dlg.FileName;
                btn_restore.Enabled = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            try
            {
                TKBUS.Restore(txt_restore.Text);
                MessageBox.Show("Restore dữ liệu thành công"); 
                txt_restore.Clear();
                btn_restore.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Mess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            btn_restore.Enabled = false;
            btn_backup.Enabled = false;
            txt_backup.Enabled = false;
            txt_restore.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

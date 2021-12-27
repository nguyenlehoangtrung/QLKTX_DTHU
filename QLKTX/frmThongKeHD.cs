using Microsoft.Reporting.WinForms;
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
using QLKTX.DTO;
using QLKTX.DAO;

namespace QLKTX
{
    public partial class frmThongKeHD : Form
    {
        Thongke_BUS TKBUS = new Thongke_BUS();
        public frmThongKeHD()
        {
            InitializeComponent();
        }

        private void frmThongKeHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKTXDataSet.HOPDONG' table. You can move, or remove it, as needed.
            this.hOPDONGTableAdapter.Fill(this.qLKTXDataSet.HOPDONG);
            dataGridView1.DataSource = TKBUS.GetList(cbo_ngaylap.Text);
            int count = dataGridView1.Rows.Count;
            lbl_tong.Text =("Tổng số hợp đồng: "+ count.ToString());
        }

        public void load()
        {
            dataGridView1.DataSource = TKBUS.GetList(cbo_ngaylap.Text);
            int count = dataGridView1.Rows.Count;
            lbl_tong.Text = ("Tổng số hợp đồng: " + count.ToString());
            dataGridView1.Columns[0].HeaderText = "Mã hợp đồng";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Tên sinh viên";
            dataGridView1.Columns[3].HeaderText = "Tên phòng";
            dataGridView1.Columns[4].HeaderText = "Loại hợp đồng";
            dataGridView1.Columns[5].HeaderText = "Ngày lập";
            dataGridView1.Columns[6].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[7].HeaderText = "Ngày kết thúc";
            dataGridView1.Columns[8].HeaderText = "Số tiền";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 150;
        }

        private void cbo_ngaylap_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                worksheet.Cells[1, j + 1] = dataGridView1.Columns[j].HeaderText;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tong_Click(object sender, EventArgs e)
        {

        }
    }
}

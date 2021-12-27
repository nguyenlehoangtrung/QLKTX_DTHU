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
using QLKTX.BUS;
using ExcelDataReader;
using System.IO;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace QLKTX
{
    public partial class frmSinhVien : Form
    {
        Sinhvien_BUS SVBUS = new Sinhvien_BUS();
        string flag;
        DataTableCollection tableCollection;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txt_mssv.Clear();
            txt_hoten.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKTXDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLKTXDataSet.SINHVIEN);
            dataGridView1.DataSource = SVBUS.GetList();
            dataGridView1.Columns[0].HeaderText = "MSSV";
            dataGridView1.Columns[1].HeaderText = "Họ Tên";
            dataGridView1.Columns[2].HeaderText = "Giới Tính";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            txt_mssv.Enabled = false;
            txt_hoten.Enabled = false;
            txt_diachi.Enabled = false;
            txt_sdt.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "them";
            txt_mssv.Enabled = true;
            txt_hoten.Enabled = true;
            txt_diachi.Enabled = true;
            txt_sdt.Enabled = true;
            dateTimePicker1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            clear();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "sua";
            txt_hoten.Enabled = true;
            txt_diachi.Enabled = true;
            txt_sdt.Enabled = true;
            dateTimePicker1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            clear();
            txt_mssv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_mssv.Enabled = false;
            txt_hoten.Enabled = false;
            txt_diachi.Enabled = false;
            txt_sdt.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            clear();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag == "them")
            {
                Sinhvien sv = new Sinhvien();
                sv.MSSV = txt_mssv.Text;
                sv.HoTen = txt_hoten.Text;
                if (radioButton1.Checked == true)
                    sv.GioiTinh = "Nam";
                else if (radioButton2.Checked == true)
                    sv.GioiTinh = "Nữ";
                sv.NgaySinh = dateTimePicker1.Value.Date;
                sv.SDT = txt_sdt.Text;
                sv.DiaChi = txt_diachi.Text;

                //check lỗi
                int check = SVBUS.Them(sv);
                if (check == 0)
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin");
                }

                else if (check == -1)
                {
                    MessageBox.Show("Mã đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                clear();
                dataGridView1.DataSource = SVBUS.GetList();
            }
            else if (flag == "sua")
            {
                Sinhvien sv = new Sinhvien();
                sv.MSSV = txt_mssv.Text;
                sv.HoTen = txt_hoten.Text;
                if (radioButton1.Checked == true)
                    sv.GioiTinh = "Nam";
                else if (radioButton2.Checked == true)
                    sv.GioiTinh = "Nữ";
                sv.NgaySinh = dateTimePicker1.Value.Date;
                sv.SDT = txt_sdt.Text;
                sv.DiaChi = txt_diachi.Text;
                //check lỗi
                if (!SVBUS.Sua(sv))
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                clear();
                dataGridView1.DataSource = SVBUS.GetList();

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mssv.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SVBUS.Xoa(txt_mssv.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmSinhVien_Load(sender, e);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                dataGridView1.DataSource = SVBUS.GetList();
            }
            else
                dataGridView1.DataSource = SVBUS.TimKiem(txt_search.Text);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataGridView1.CurrentRow.Index;
            txt_mssv.Text = dataGridView1[0, chiso].Value.ToString();
            txt_hoten.Text = dataGridView1[1, chiso].Value.ToString();
            string a = dataGridView1[2, chiso].Value.ToString();
            if (a == "Nam")
                radioButton1.Checked = true;
            else if (a == "Nữ")
                radioButton2.Checked = true;
            dateTimePicker1.Value = (DateTime)dataGridView1[3, chiso].Value;
            txt_sdt.Text = dataGridView1[4, chiso].Value.ToString();
            txt_diachi.Text = dataGridView1[5, chiso].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mofile_Click(object sender, EventArgs e)
        {

        }

        private void btn_chonfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbo_sheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbo_sheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cbo_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbo_sheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<Sinhvien> sinhviens = new List<Sinhvien>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Sinhvien sinhvien = new Sinhvien();
                    sinhvien.MSSV = dt.Rows[i]["MSSV"].ToString();
                    sinhvien.HoTen = dt.Rows[i]["Họ Tên"].ToString();
                    sinhvien.GioiTinh = dt.Rows[i]["Giới Tính"].ToString();
                    sinhvien.NgaySinh = (DateTime)dt.Rows[i]["Ngày Sinh"];
                    sinhvien.SDT = dt.Rows[i]["Số Điện Thoại"].ToString();
                    sinhvien.DiaChi = dt.Rows[i]["Địa Chỉ"].ToString();
                    sinhviens.Add(sinhvien);
                }
                sINHVIENBindingSource.DataSource = sinhviens;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.;Initial Catalog = QLKTX; Integrated Security = True";
                DapperPlusManager.Entity<Sinhvien>().Table("SINHVIEN");
                List<Sinhvien> sinhviens = sINHVIENBindingSource.DataSource as List<Sinhvien>;
                if (sinhviens != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(sinhviens);
                    }
                }
                MessageBox.Show("Import dữ liệu thành công !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

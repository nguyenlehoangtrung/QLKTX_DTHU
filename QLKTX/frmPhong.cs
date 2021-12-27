using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using QLKTX.DTO;
using QLKTX.BUS;
using ExcelDataReader;
using Z.Dapper.Plus;

namespace QLKTX
{
    public partial class frmPhong : Form
    {
        Phong_BUS PhongBUS = new Phong_BUS();
        string flag;
        DataTableCollection tableCollection;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKTXDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLKTXDataSet.PHONG);

            dataGridView1.DataSource = PhongBUS.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã phòng";
            dataGridView1.Columns[1].HeaderText = "Tên phòng";
            dataGridView1.Columns[2].HeaderText = "Kích thước";
            dataGridView1.Columns[3].HeaderText = "Dãy";
            dataGridView1.Columns[4].HeaderText = "Loại giường";

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            txt_maphong.Enabled = false;
            txt_tenphong.Enabled = false;
            cbo_day.Enabled = false;
            cbo_kichthuoc.Enabled = false;
            cbo_loaigiuong.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "them";
            txt_maphong.Enabled = true;
            txt_tenphong.Enabled = true;
            cbo_day.Enabled = true;
            cbo_kichthuoc.Enabled = true;
            cbo_loaigiuong.Enabled = true;
            txt_maphong.Clear();
            txt_tenphong.Clear();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataGridView1.CurrentRow.Index;
            txt_maphong.Text = dataGridView1[0, chiso].Value.ToString();
            txt_tenphong.Text = dataGridView1[1, chiso].Value.ToString();
            cbo_kichthuoc.Text = dataGridView1[2, chiso].Value.ToString();
            cbo_day.Text = dataGridView1[3, chiso].Value.ToString();
            cbo_loaigiuong.Text = dataGridView1[4, chiso].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "sua";
            txt_maphong.Enabled = false;
            txt_tenphong.Enabled = true;
            cbo_day.Enabled = true;
            cbo_kichthuoc.Enabled = true;
            cbo_loaigiuong.Enabled = true;
            txt_maphong.Clear();
            txt_tenphong.Clear();
            
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maphong.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PhongBUS.Xoa(txt_maphong.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmPhong_Load(sender, e);
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = PhongBUS.GetList();
            }
            else
                dataGridView1.DataSource = PhongBUS.TimKiem(txt_timkiem.Text);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_maphong.Enabled = false;
            txt_tenphong.Enabled = false;
            cbo_day.Enabled = false;
            cbo_kichthuoc.Enabled = false;
            cbo_loaigiuong.Enabled = false;
            txt_maphong.Clear();
            txt_tenphong.Clear();

            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag == "them")
            {
                Phong p = new Phong();
                p.MaPhong = txt_maphong.Text;
                p.TenPhong = txt_tenphong.Text;
                p.KichThuoc = cbo_kichthuoc.Text;
                p.DayPhong = cbo_day.Text;
                p.LoaiGiuong = cbo_loaigiuong.Text;

                //check lỗi
                int check = PhongBUS.Them(p);
                if (check == 0)
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin");
                else if (check == -1)
                    MessageBox.Show("Mã đã tồn tại");
                else
                    MessageBox.Show("Thêm thành công", "Thông báo");
                txt_maphong.Clear();
                txt_tenphong.Clear();
                dataGridView1.DataSource = PhongBUS.GetList();
            }
            else if (flag == "sua")
            {
                Phong p = new Phong();
                p.MaPhong = txt_maphong.Text;
                p.TenPhong = txt_tenphong.Text;
                p.KichThuoc = cbo_kichthuoc.Text;
                p.DayPhong = cbo_day.Text;
                p.LoaiGiuong = cbo_loaigiuong.Text;
                //check lỗi
                if (!PhongBUS.Sua(p))
                    MessageBox.Show("Sửa thất bại","Thông báo");
                else
                    MessageBox.Show("Sửa thành công", "Thông báo");
                txt_maphong.Clear();
                txt_tenphong.Clear();
                dataGridView1.DataSource = PhongBUS.GetList();
            }
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

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.;Initial Catalog = QLKTX; Integrated Security = True";
                DapperPlusManager.Entity<Phong>().Table("PHONG");
                List<Phong> phongs = pHONGBindingSource.DataSource as List<Phong>;
                if (phongs != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(phongs);
                    }
                }
                MessageBox.Show("Import dữ liệu thành công !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Mess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chonfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
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
            if (dt != null)
            {
                List<Phong> phongs = new List<Phong>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Phong phong = new Phong();
                    phong.MaPhong = dt.Rows[i]["Mã phòng"].ToString();
                    phong.TenPhong = dt.Rows[i]["Tên phòng"].ToString();
                    phong.KichThuoc = dt.Rows[i]["Kích thước"].ToString();
                    phong.DayPhong = dt.Rows[i]["Dãy"].ToString();
                    phong.LoaiGiuong = dt.Rows[i]["Loại giường"].ToString();
                    phongs.Add(phong);
                }
                pHONGBindingSource.DataSource = phongs;
            }
        }
    }
}

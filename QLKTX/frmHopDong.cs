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
    public partial class frmHopDong : Form
    {
        Hopdong_BUS HDBUS = new Hopdong_BUS();
        string flag;
        DataTableCollection tableCollection;
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txt_mahd.Clear();
            txt_sotien.Clear();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKTXDataSet.HOPDONG' table. You can move, or remove it, as needed.
            this.hOPDONGTableAdapter.Fill(this.qLKTXDataSet.HOPDONG);
            // TODO: This line of code loads data into the 'qLKTXDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLKTXDataSet.PHONG);
            // TODO: This line of code loads data into the 'qLKTXDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLKTXDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLKTXDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLKTXDataSet.NHANVIEN);


            dataGridView1.DataSource = HDBUS.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã hợp đồng";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].HeaderText = "MSSV";
            dataGridView1.Columns[3].HeaderText = "Mã phòng";     
            dataGridView1.Columns[4].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[5].HeaderText = "Ngày kết thúc";
            dataGridView1.Columns[6].HeaderText = "Loại hợp đồng";
            dataGridView1.Columns[7].HeaderText = "Ngày lập";
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
            txt_mahd.Enabled = false;
            cbo_manv.Enabled = false;
            cbo_mssv.Enabled = false;
            cbo_maphong.Enabled = false;
            dateTimePicker_BD.Enabled = false;
            dateTimePicker_KT.Enabled = false;
            cbo_loaihd.Enabled = false;
            dateTimePicker_Ngaylap.Enabled = false;
            txt_sotien.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "them";
            txt_mahd.Enabled = false;
            cbo_manv.Enabled = true;
            cbo_mssv.Enabled = true;
            cbo_maphong.Enabled = true;
            dateTimePicker_BD.Enabled = true;
            dateTimePicker_KT.Enabled = true;
            cbo_loaihd.Enabled = true;
            dateTimePicker_Ngaylap.Enabled = true;
            txt_sotien.Enabled = true;
            clear();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            int count= dataGridView1.Rows.Count;
            txt_mahd.Text = (count + 1).ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_mahd.Enabled = false;
            cbo_manv.Enabled = true;
            cbo_mssv.Enabled = true;
            cbo_maphong.Enabled = true;
            dateTimePicker_BD.Enabled = true;
            dateTimePicker_KT.Enabled = true;
            cbo_loaihd.Enabled = true;
            dateTimePicker_Ngaylap.Enabled = true;
            txt_sotien.Enabled = true;
            flag = "sua";
            clear();
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag == "them")
            {
                Hopdong hd = new Hopdong();
                hd.MaHD = txt_mahd.Text;
                hd.MaNV = cbo_manv.Text;
                hd.MSSV = cbo_mssv.Text;
                hd.MaPhong = cbo_maphong.Text;
                hd.LoaiHD = cbo_loaihd.Text;
                hd.NgayLap = dateTimePicker_Ngaylap.Value.Date;
                hd.NgayBD = dateTimePicker_BD.Value.Date;
                hd.NgayKT = dateTimePicker_KT.Value.Date;
                hd.SoTien = txt_sotien.Text;

                //check lỗi
                int check = HDBUS.Them(hd);
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
                dataGridView1.DataSource = HDBUS.GetList();
            }
            else if (flag == "sua")
            {
                Hopdong hd = new Hopdong();
                hd.MaHD = txt_mahd.Text;
                hd.MaNV = cbo_manv.Text;
                hd.MSSV = cbo_mssv.Text;
                hd.MaPhong = cbo_maphong.Text;
                hd.LoaiHD = cbo_loaihd.Text;
                hd.NgayLap = dateTimePicker_Ngaylap.Value.Date;
                hd.NgayBD = dateTimePicker_BD.Value.Date;
                hd.NgayKT = dateTimePicker_KT.Value.Date;
                hd.SoTien = txt_sotien.Text;
                //check lỗi
                if (!HDBUS.Sua(hd))
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                clear();
                dataGridView1.DataSource = HDBUS.GetList();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    HDBUS.Xoa(txt_mahd.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmHopDong_Load(sender, e);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_mahd.Enabled = false;
            cbo_manv.Enabled = false;
            cbo_mssv.Enabled = false;
            cbo_maphong.Enabled = false;
            dateTimePicker_BD.Enabled = false;
            dateTimePicker_KT.Enabled = false;
            cbo_loaihd.Enabled = false;
            dateTimePicker_Ngaylap.Enabled = false;
            txt_sotien.Enabled = false;
            clear();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
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
            txt_mahd.Text = dataGridView1[0, chiso].Value.ToString();
            cbo_manv.Text = dataGridView1[1, chiso].Value.ToString();           
            cbo_mssv.Text = dataGridView1[2, chiso].Value.ToString();
            cbo_maphong.Text = dataGridView1[3, chiso].Value.ToString();
            dateTimePicker_BD.Value = (DateTime)dataGridView1[4, chiso].Value;
            dateTimePicker_KT.Value = (DateTime)dataGridView1[5, chiso].Value;
            cbo_loaihd.Text = dataGridView1[6, chiso].Value.ToString();
            dateTimePicker_Ngaylap.Value = (DateTime)dataGridView1[7, chiso].Value;
            txt_sotien.Text = dataGridView1[8, chiso].Value.ToString();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = HDBUS.GetList();
            }
            else
                dataGridView1.DataSource = HDBUS.TimKiem(txt_timkiem.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                List<Hopdong> hopdongs = new List<Hopdong>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Hopdong hopdong = new Hopdong();
                    hopdong.MaHD = dt.Rows[i]["Mã hợp đồng"].ToString();
                    hopdong.MaNV = dt.Rows[i]["Mã nhân viên"].ToString();
                    hopdong.MSSV = dt.Rows[i]["MSSV"].ToString();
                    hopdong.MaPhong = dt.Rows[i]["Mã phòng"].ToString();
                    hopdong.NgayBD = (DateTime)dt.Rows[i]["Ngày bắt đầu"];
                    hopdong.NgayKT = (DateTime)dt.Rows[i]["Ngày kết thúc"];
                    hopdong.LoaiHD = dt.Rows[i]["Loại hợp đồng"].ToString();
                    hopdong.NgayLap = (DateTime)dt.Rows[i]["Ngày lập"];
                    hopdong.SoTien = dt.Rows[i]["Số tiền"].ToString();
                    hopdongs.Add(hopdong);
                }
                hOPDONGBindingSource.DataSource = hopdongs;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.;Initial Catalog = QLKTX; Integrated Security = True";
                DapperPlusManager.Entity<Hopdong>().Table("HOPDONG");
                List<Hopdong> hopdongs = hOPDONGBindingSource.DataSource as List<Hopdong>;
                if (hopdongs != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(hopdongs);
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

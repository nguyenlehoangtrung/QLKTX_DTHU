
namespace QLKTX
{
    partial class frmHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.nHANVIENbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKTXDataSet = new QLKTX.QLKTXDataSet();
            this.nHANVIENTableAdapter = new QLKTX.QLKTXDataSetTableAdapters.NHANVIENTableAdapter();
            this.sINHVIENbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLKTX.QLKTXDataSetTableAdapters.SINHVIENTableAdapter();
            this.pHONGbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new QLKTX.QLKTXDataSetTableAdapters.PHONGTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_BD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_KT = new System.Windows.Forms.DateTimePicker();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            this.cbo_maphong = new System.Windows.Forms.ComboBox();
            this.cbo_mssv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_loaihd = new System.Windows.Forms.ComboBox();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_Ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOPDONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_sheet = new System.Windows.Forms.ComboBox();
            this.btn_chonfile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hOPDONGTableAdapter = new QLKTX.QLKTXDataSetTableAdapters.HOPDONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGbindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nHANVIENbindingSource
            // 
            this.nHANVIENbindingSource.DataMember = "NHANVIEN";
            this.nHANVIENbindingSource.DataSource = this.qLKTXDataSet;
            // 
            // qLKTXDataSet
            // 
            this.qLKTXDataSet.DataSetName = "QLKTXDataSet";
            this.qLKTXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENbindingSource
            // 
            this.sINHVIENbindingSource.DataMember = "SINHVIEN";
            this.sINHVIENbindingSource.DataSource = this.qLKTXDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGbindingSource
            // 
            this.pHONGbindingSource.DataMember = "PHONG";
            this.pHONGbindingSource.DataSource = this.qLKTXDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(667, 563);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.ForeColor = System.Drawing.Color.Black;
            this.txt_timkiem.Location = new System.Drawing.Point(732, 561);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(186, 26);
            this.txt_timkiem.TabIndex = 56;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "MSSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.Location = new System.Drawing.Point(134, 39);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(173, 25);
            this.txt_mahd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày kết thúc";
            // 
            // dateTimePicker_BD
            // 
            this.dateTimePicker_BD.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_BD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_BD.Location = new System.Drawing.Point(447, 72);
            this.dateTimePicker_BD.Name = "dateTimePicker_BD";
            this.dateTimePicker_BD.Size = new System.Drawing.Size(173, 25);
            this.dateTimePicker_BD.TabIndex = 17;
            // 
            // dateTimePicker_KT
            // 
            this.dateTimePicker_KT.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_KT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_KT.Location = new System.Drawing.Point(447, 106);
            this.dateTimePicker_KT.Name = "dateTimePicker_KT";
            this.dateTimePicker_KT.Size = new System.Drawing.Size(173, 25);
            this.dateTimePicker_KT.TabIndex = 18;
            // 
            // cbo_manv
            // 
            this.cbo_manv.DataSource = this.nHANVIENbindingSource;
            this.cbo_manv.DisplayMember = "MaNV";
            this.cbo_manv.DropDownHeight = 100;
            this.cbo_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_manv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.IntegralHeight = false;
            this.cbo_manv.Location = new System.Drawing.Point(134, 72);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(173, 27);
            this.cbo_manv.TabIndex = 19;
            this.cbo_manv.ValueMember = "MaNV";
            // 
            // cbo_maphong
            // 
            this.cbo_maphong.DataSource = this.pHONGbindingSource;
            this.cbo_maphong.DisplayMember = "MaPhong";
            this.cbo_maphong.DropDownHeight = 100;
            this.cbo_maphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maphong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_maphong.FormattingEnabled = true;
            this.cbo_maphong.IntegralHeight = false;
            this.cbo_maphong.Location = new System.Drawing.Point(134, 140);
            this.cbo_maphong.Name = "cbo_maphong";
            this.cbo_maphong.Size = new System.Drawing.Size(173, 27);
            this.cbo_maphong.TabIndex = 20;
            this.cbo_maphong.ValueMember = "MaPhong";
            // 
            // cbo_mssv
            // 
            this.cbo_mssv.DataSource = this.sINHVIENbindingSource;
            this.cbo_mssv.DisplayMember = "MSSV";
            this.cbo_mssv.DropDownHeight = 100;
            this.cbo_mssv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mssv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_mssv.FormattingEnabled = true;
            this.cbo_mssv.IntegralHeight = false;
            this.cbo_mssv.Location = new System.Drawing.Point(134, 106);
            this.cbo_mssv.Name = "cbo_mssv";
            this.cbo_mssv.Size = new System.Drawing.Size(173, 27);
            this.cbo_mssv.TabIndex = 21;
            this.cbo_mssv.ValueMember = "MSSV";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbo_loaihd);
            this.groupBox1.Controls.Add(this.txt_sotien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker_Ngaylap);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_mssv);
            this.groupBox1.Controls.Add(this.cbo_maphong);
            this.groupBox1.Controls.Add(this.cbo_manv);
            this.groupBox1.Controls.Add(this.dateTimePicker_KT);
            this.groupBox1.Controls.Add(this.dateTimePicker_BD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(657, 223);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // cbo_loaihd
            // 
            this.cbo_loaihd.DropDownHeight = 100;
            this.cbo_loaihd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaihd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaihd.FormattingEnabled = true;
            this.cbo_loaihd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbo_loaihd.IntegralHeight = false;
            this.cbo_loaihd.Items.AddRange(new object[] {
            "Thuê phòng",
            "Gia hạn hợp đồng"});
            this.cbo_loaihd.Location = new System.Drawing.Point(134, 174);
            this.cbo_loaihd.Name = "cbo_loaihd";
            this.cbo_loaihd.Size = new System.Drawing.Size(173, 27);
            this.cbo_loaihd.TabIndex = 71;
            // 
            // txt_sotien
            // 
            this.txt_sotien.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sotien.Location = new System.Drawing.Point(447, 138);
            this.txt_sotien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(173, 25);
            this.txt_sotien.TabIndex = 70;
            this.txt_sotien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(384, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Số tiền";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dateTimePicker_Ngaylap
            // 
            this.dateTimePicker_Ngaylap.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Ngaylap.Location = new System.Drawing.Point(447, 39);
            this.dateTimePicker_Ngaylap.Name = "dateTimePicker_Ngaylap";
            this.dateTimePicker_Ngaylap.Size = new System.Drawing.Size(173, 25);
            this.dateTimePicker_Ngaylap.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(373, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Ngày lập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Loại hợp đồng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.mSSVDataGridViewTextBoxColumn,
            this.maPhongDataGridViewTextBoxColumn,
            this.ngayBDDataGridViewTextBoxColumn,
            this.ngayKTDataGridViewTextBoxColumn,
            this.loaiHDDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.soTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOPDONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 165);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            this.mSSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayBDDataGridViewTextBoxColumn
            // 
            this.ngayBDDataGridViewTextBoxColumn.DataPropertyName = "NgayBD";
            this.ngayBDDataGridViewTextBoxColumn.HeaderText = "NgayBD";
            this.ngayBDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBDDataGridViewTextBoxColumn.Name = "ngayBDDataGridViewTextBoxColumn";
            this.ngayBDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayKTDataGridViewTextBoxColumn
            // 
            this.ngayKTDataGridViewTextBoxColumn.DataPropertyName = "NgayKT";
            this.ngayKTDataGridViewTextBoxColumn.HeaderText = "NgayKT";
            this.ngayKTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKTDataGridViewTextBoxColumn.Name = "ngayKTDataGridViewTextBoxColumn";
            this.ngayKTDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiHDDataGridViewTextBoxColumn
            // 
            this.loaiHDDataGridViewTextBoxColumn.DataPropertyName = "LoaiHD";
            this.loaiHDDataGridViewTextBoxColumn.HeaderText = "LoaiHD";
            this.loaiHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiHDDataGridViewTextBoxColumn.Name = "loaiHDDataGridViewTextBoxColumn";
            this.loaiHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "SoTien";
            this.soTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hOPDONGBindingSource
            // 
            this.hOPDONGBindingSource.DataMember = "HOPDONG";
            this.hOPDONGBindingSource.DataSource = this.qLKTXDataSet;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(725, 42);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 61);
            this.btn_them.TabIndex = 61;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(825, 42);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 61);
            this.btn_sua.TabIndex = 59;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(725, 116);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 61);
            this.btn_xoa.TabIndex = 62;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.ForeColor = System.Drawing.Color.Black;
            this.btn_xuat.Location = new System.Drawing.Point(533, 24);
            this.btn_xuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(96, 61);
            this.btn_xuat.TabIndex = 63;
            this.btn_xuat.Text = "Xuất Excel";
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.Control;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(825, 116);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(92, 60);
            this.btn_luu.TabIndex = 64;
            this.btn_luu.Text = "LƯU";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.SystemColors.Control;
            this.btn_import.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.Black;
            this.btn_import.Location = new System.Drawing.Point(414, 24);
            this.btn_import.Margin = new System.Windows.Forms.Padding(2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(96, 61);
            this.btn_import.TabIndex = 65;
            this.btn_import.Text = "Nhập Excel";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(725, 192);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(191, 64);
            this.btn_refresh.TabIndex = 67;
            this.btn_refresh.Text = "RELOAD";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_sheet);
            this.groupBox2.Controls.Add(this.btn_chonfile);
            this.groupBox2.Controls.Add(this.btn_import);
            this.groupBox2.Controls.Add(this.btn_xuat);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(37, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 102);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập - Xuất dữ liệu";
            // 
            // cbo_sheet
            // 
            this.cbo_sheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sheet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sheet.FormattingEnabled = true;
            this.cbo_sheet.ItemHeight = 19;
            this.cbo_sheet.Location = new System.Drawing.Point(134, 63);
            this.cbo_sheet.Name = "cbo_sheet";
            this.cbo_sheet.Size = new System.Drawing.Size(173, 27);
            this.cbo_sheet.TabIndex = 71;
            this.cbo_sheet.SelectedIndexChanged += new System.EventHandler(this.cbo_sheet_SelectedIndexChanged);
            // 
            // btn_chonfile
            // 
            this.btn_chonfile.Location = new System.Drawing.Point(134, 23);
            this.btn_chonfile.Name = "btn_chonfile";
            this.btn_chonfile.Size = new System.Drawing.Size(48, 28);
            this.btn_chonfile.TabIndex = 3;
            this.btn_chonfile.Text = "...";
            this.btn_chonfile.UseVisualStyleBackColor = true;
            this.btn_chonfile.Click += new System.EventHandler(this.btn_chonfile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Chọn file";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sheet";
            // 
            // hOPDONGTableAdapter
            // 
            this.hOPDONGTableAdapter.ClearBeforeFill = true;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGbindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource nHANVIENbindingSource;
        private QLKTXDataSet qLKTXDataSet;
        private QLKTXDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENbindingSource;
        private QLKTXDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource pHONGbindingSource;
        private QLKTXDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KT;
        private System.Windows.Forms.ComboBox cbo_manv;
        private System.Windows.Forms.ComboBox cbo_maphong;
        private System.Windows.Forms.ComboBox cbo_mssv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ngaylap;
        private System.Windows.Forms.TextBox txt_sotien;
        private System.Windows.Forms.ComboBox cbo_loaihd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_sheet;
        private System.Windows.Forms.Button btn_chonfile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource hOPDONGBindingSource;
        private QLKTXDataSetTableAdapters.HOPDONGTableAdapter hOPDONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
    }
}
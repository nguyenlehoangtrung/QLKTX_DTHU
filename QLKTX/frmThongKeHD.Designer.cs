
namespace QLKTX
{
    partial class frmThongKeHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeHD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ngaylap = new System.Windows.Forms.ComboBox();
            this.hOPDONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKTXDataSet = new QLKTX.QLKTXDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.hOPDONGTableAdapter = new QLKTX.QLKTXDataSetTableAdapters.HOPDONGTableAdapter();
            this.reportHD = new QLKTX.ReportHD();
            this.reportHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDONGTableAdapter1 = new QLKTX.ReportHDTableAdapters.HOPDONGTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_ngaylap);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 63);
            this.panel1.TabIndex = 0;
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(506, 6);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(107, 51);
            this.btn_xuat.TabIndex = 2;
            this.btn_xuat.Text = " XUẤT EXCEL";
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày lập hợp đồng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_ngaylap
            // 
            this.cbo_ngaylap.DataSource = this.hOPDONGBindingSource;
            this.cbo_ngaylap.DisplayMember = "NgayLap";
            this.cbo_ngaylap.DropDownHeight = 100;
            this.cbo_ngaylap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ngaylap.FormattingEnabled = true;
            this.cbo_ngaylap.IntegralHeight = false;
            this.cbo_ngaylap.Location = new System.Drawing.Point(301, 21);
            this.cbo_ngaylap.Name = "cbo_ngaylap";
            this.cbo_ngaylap.Size = new System.Drawing.Size(150, 27);
            this.cbo_ngaylap.TabIndex = 0;
            this.cbo_ngaylap.ValueMember = "NgayLap";
            this.cbo_ngaylap.SelectedIndexChanged += new System.EventHandler(this.cbo_ngaylap_SelectedIndexChanged);
            // 
            // hOPDONGBindingSource
            // 
            this.hOPDONGBindingSource.DataMember = "HOPDONG";
            this.hOPDONGBindingSource.DataSource = this.qLKTXDataSet;
            // 
            // qLKTXDataSet
            // 
            this.qLKTXDataSet.DataSetName = "QLKTXDataSet";
            this.qLKTXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(208, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "THỐNG KÊ HỢP ĐỒNG THEO NGÀY";
            // 
            // hOPDONGTableAdapter
            // 
            this.hOPDONGTableAdapter.ClearBeforeFill = true;
            // 
            // reportHD
            // 
            this.reportHD.DataSetName = "ReportHD";
            this.reportHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportHDBindingSource
            // 
            this.reportHDBindingSource.DataSource = this.reportHD;
            this.reportHDBindingSource.Position = 0;
            // 
            // hOPDONGBindingSource1
            // 
            this.hOPDONGBindingSource1.DataMember = "HOPDONG";
            this.hOPDONGBindingSource1.DataSource = this.reportHDBindingSource;
            // 
            // hOPDONGTableAdapter1
            // 
            this.hOPDONGTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(24, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 202);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(752, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tong.Location = new System.Drawing.Point(642, 383);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(125, 19);
            this.lbl_tong.TabIndex = 4;
            this.lbl_tong.Text = "Tổng số hợp đồng:";
            this.lbl_tong.Click += new System.EventHandler(this.lbl_tong_Click);
            // 
            // frmThongKeHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 422);
            this.Controls.Add(this.lbl_tong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hợp đồng";
            this.Load += new System.EventHandler(this.frmThongKeHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QLKTXDataSet qLKTXDataSet;
        private System.Windows.Forms.BindingSource hOPDONGBindingSource;
        private QLKTXDataSetTableAdapters.HOPDONGTableAdapter hOPDONGTableAdapter;
        private System.Windows.Forms.BindingSource reportHDBindingSource;
        private ReportHD reportHD;
        private System.Windows.Forms.BindingSource hOPDONGBindingSource1;
        private ReportHDTableAdapters.HOPDONGTableAdapter hOPDONGTableAdapter1;
        private System.Windows.Forms.ComboBox cbo_ngaylap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_tong;
    }
}
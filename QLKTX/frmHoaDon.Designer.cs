
namespace QLKTX
{
    partial class frmHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.HOPDONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHD = new QLKTX.ReportHD();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.cbo_tensv = new System.Windows.Forms.ComboBox();
            this.hOPDONGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLKTXDataSet = new QLKTX.QLKTXDataSet();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKTXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOPDONGTableAdapter = new QLKTX.ReportHDTableAdapters.HOPDONGTableAdapter();
            this.hOPDONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDONGTableAdapter1 = new QLKTX.QLKTXDataSetTableAdapters.HOPDONGTableAdapter();
            this.sINHVIENTableAdapter = new QLKTX.QLKTXDataSetTableAdapters.SINHVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HOPDONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // HOPDONGBindingSource
            // 
            this.HOPDONGBindingSource.DataMember = "HOPDONG";
            this.HOPDONGBindingSource.DataSource = this.ReportHD;
            // 
            // ReportHD
            // 
            this.ReportHD.DataSetName = "ReportHD";
            this.ReportHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_xuat
            // 
            this.btn_xuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(422, 89);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(77, 34);
            this.btn_xuat.TabIndex = 0;
            this.btn_xuat.Text = "XUẤT";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // cbo_tensv
            // 
            this.cbo_tensv.DataSource = this.hOPDONGBindingSource2;
            this.cbo_tensv.DisplayMember = "MAHD";
            this.cbo_tensv.DropDownHeight = 100;
            this.cbo_tensv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tensv.FormattingEnabled = true;
            this.cbo_tensv.IntegralHeight = false;
            this.cbo_tensv.Location = new System.Drawing.Point(201, 94);
            this.cbo_tensv.Name = "cbo_tensv";
            this.cbo_tensv.Size = new System.Drawing.Size(177, 27);
            this.cbo_tensv.TabIndex = 1;
            this.cbo_tensv.ValueMember = "MAHD";
            // 
            // hOPDONGBindingSource2
            // 
            this.hOPDONGBindingSource2.DataMember = "HOPDONG";
            this.hOPDONGBindingSource2.DataSource = this.qLKTXDataSet;
            // 
            // qLKTXDataSet
            // 
            this.qLKTXDataSet.DataSetName = "QLKTXDataSet";
            this.qLKTXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource1
            // 
            this.sINHVIENBindingSource1.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource1.DataSource = this.qLKTXDataSet;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLKTXDataSetBindingSource;
            // 
            // qLKTXDataSetBindingSource
            // 
            this.qLKTXDataSetBindingSource.DataSource = this.qLKTXDataSet;
            this.qLKTXDataSetBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOPDONGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKTX.ReportHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(646, 575);
            this.reportViewer1.TabIndex = 2;
            // 
            // HOPDONGTableAdapter
            // 
            this.HOPDONGTableAdapter.ClearBeforeFill = true;
            // 
            // hOPDONGBindingSource1
            // 
            this.hOPDONGBindingSource1.DataMember = "HOPDONG";
            this.hOPDONGBindingSource1.DataSource = this.qLKTXDataSetBindingSource;
            // 
            // hOPDONGTableAdapter1
            // 
            this.hOPDONGTableAdapter1.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hợp đồng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(166, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "XUẤT HÓA ĐƠN THU TIỀN";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbo_tensv);
            this.Controls.Add(this.btn_xuat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hóa đơn thu tiền";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOPDONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.ComboBox cbo_tensv;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOPDONGBindingSource;
        private ReportHD ReportHD;
        private ReportHDTableAdapters.HOPDONGTableAdapter HOPDONGTableAdapter;
        private System.Windows.Forms.BindingSource qLKTXDataSetBindingSource;
        private QLKTXDataSet qLKTXDataSet;
        private System.Windows.Forms.BindingSource hOPDONGBindingSource1;
        private QLKTXDataSetTableAdapters.HOPDONGTableAdapter hOPDONGTableAdapter1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLKTXDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hOPDONGBindingSource2;
    }
}
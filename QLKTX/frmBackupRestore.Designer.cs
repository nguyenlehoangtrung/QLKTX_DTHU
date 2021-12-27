
namespace QLKTX
{
    partial class frmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupRestore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_filebk = new System.Windows.Forms.Button();
            this.txt_backup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_filers = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.txt_restore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Controls.Add(this.btn_filebk);
            this.groupBox1.Controls.Add(this.txt_backup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BACKUP";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(439, 27);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(73, 39);
            this.btn_backup.TabIndex = 5;
            this.btn_backup.Text = "BACKUP";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_filebk
            // 
            this.btn_filebk.Location = new System.Drawing.Point(333, 34);
            this.btn_filebk.Name = "btn_filebk";
            this.btn_filebk.Size = new System.Drawing.Size(57, 29);
            this.btn_filebk.TabIndex = 4;
            this.btn_filebk.Text = "...";
            this.btn_filebk.UseVisualStyleBackColor = true;
            this.btn_filebk.Click += new System.EventHandler(this.btn_filebk_Click);
            // 
            // txt_backup
            // 
            this.txt_backup.Location = new System.Drawing.Point(125, 37);
            this.txt_backup.Name = "txt_backup";
            this.txt_backup.Size = new System.Drawing.Size(178, 26);
            this.txt_backup.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_filers);
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.txt_restore);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESTORE";
            // 
            // btn_filers
            // 
            this.btn_filers.Location = new System.Drawing.Point(333, 32);
            this.btn_filers.Name = "btn_filers";
            this.btn_filers.Size = new System.Drawing.Size(57, 29);
            this.btn_filers.TabIndex = 6;
            this.btn_filers.Text = "...";
            this.btn_filers.UseVisualStyleBackColor = true;
            this.btn_filers.Click += new System.EventHandler(this.btn_filers_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(439, 28);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(73, 39);
            this.btn_restore.TabIndex = 6;
            this.btn_restore.Text = "RESTORE";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // txt_restore
            // 
            this.txt_restore.Location = new System.Drawing.Point(125, 36);
            this.txt_restore.Name = "txt_restore";
            this.txt_restore.Size = new System.Drawing.Size(178, 26);
            this.txt_restore.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "BACKUP VÀ RESTORE CSDL";
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup & Restore";
            this.Load += new System.EventHandler(this.frmBackupRestore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_filebk;
        private System.Windows.Forms.TextBox txt_backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_restore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_filers;
    }
}
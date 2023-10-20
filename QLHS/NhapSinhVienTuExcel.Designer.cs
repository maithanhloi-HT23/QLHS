namespace QLHS
{
    partial class NhapSinhVienTuExcel
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
            this.panelKhung = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.cmdMoTapTin = new System.Windows.Forms.Button();
            this.panelKhung.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKhung
            // 
            this.panelKhung.Controls.Add(this.panel1);
            this.panelKhung.Controls.Add(this.splitContainer1);
            this.panelKhung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKhung.Location = new System.Drawing.Point(0, 0);
            this.panelKhung.Name = "panelKhung";
            this.panelKhung.Size = new System.Drawing.Size(734, 480);
            this.panelKhung.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDanhMuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 424);
            this.panel1.TabIndex = 1;
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(734, 424);
            this.dgDanhMuc.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmdGhi);
            this.splitContainer1.Panel2.Controls.Add(this.cmdKetThuc);
            this.splitContainer1.Panel2.Controls.Add(this.cmdMoTapTin);
            this.splitContainer1.Size = new System.Drawing.Size(734, 56);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmdGhi
            // 
            this.cmdGhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdGhi.Location = new System.Drawing.Point(192, 0);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(138, 56);
            this.cmdGhi.TabIndex = 87;
            this.cmdGhi.Text = "Ghi kết quả";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdKetThuc.Location = new System.Drawing.Point(330, 0);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(156, 56);
            this.cmdKetThuc.TabIndex = 86;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdMoTapTin
            // 
            this.cmdMoTapTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdMoTapTin.Location = new System.Drawing.Point(0, 0);
            this.cmdMoTapTin.Name = "cmdMoTapTin";
            this.cmdMoTapTin.Size = new System.Drawing.Size(192, 56);
            this.cmdMoTapTin.TabIndex = 84;
            this.cmdMoTapTin.Text = "Mở tập tin";
            this.cmdMoTapTin.UseVisualStyleBackColor = true;
            this.cmdMoTapTin.Click += new System.EventHandler(this.cmdMoFile_Click);
            // 
            // NhapSinhVienTuExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 480);
            this.Controls.Add(this.panelKhung);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "NhapSinhVienTuExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sinh viên từ Excel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapSinhVienTuExcel_Load);
            this.panelKhung.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKhung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdKetThuc;
        private System.Windows.Forms.Button cmdMoTapTin;
        private System.Windows.Forms.DataGridView dgDanhMuc;
    }
}
namespace QLHS
{
    partial class frmKhoa
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
            this.txtNienkhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNienkhoa
            // 
            this.txtNienkhoa.Location = new System.Drawing.Point(167, 310);
            this.txtNienkhoa.Name = "txtNienkhoa";
            this.txtNienkhoa.Size = new System.Drawing.Size(176, 27);
            this.txtNienkhoa.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Niên khóa :";
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(511, 302);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(88, 32);
            this.cmdKhong.TabIndex = 26;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(407, 302);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(88, 32);
            this.cmdGhi.TabIndex = 25;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(543, 254);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(80, 32);
            this.cmdXoa.TabIndex = 24;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(455, 254);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(72, 32);
            this.cmdSua.TabIndex = 23;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(359, 254);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(80, 32);
            this.cmdThem.TabIndex = 22;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // lblThongbao
            // 
            this.lblThongbao.Location = new System.Drawing.Point(415, 222);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(208, 24);
            this.lblThongbao.TabIndex = 27;
            this.lblThongbao.Text = ".";
            this.lblThongbao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Location = new System.Drawing.Point(167, 270);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(176, 27);
            this.txtTenkhoa.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên khóa :";
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Location = new System.Drawing.Point(167, 230);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(176, 27);
            this.txtMakhoa.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã khóa :";
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh,
            this.NienKhoa});
            this.dgDanhMuc.Location = new System.Drawing.Point(39, 62);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(584, 150);
            this.dgDanhMuc.TabIndex = 15;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaKhoa";
            this.MaNganh.HeaderText = "Mã khóa";
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.ReadOnly = true;
            this.MaNganh.Width = 150;
            // 
            // TenNganh
            // 
            this.TenNganh.DataPropertyName = "TenKhoa";
            this.TenNganh.HeaderText = "Tên khóa";
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.ReadOnly = true;
            this.TenNganh.Width = 200;
            // 
            // NienKhoa
            // 
            this.NienKhoa.DataPropertyName = "NienKhoa";
            this.NienKhoa.HeaderText = "Niên khóa";
            this.NienKhoa.Name = "NienKhoa";
            this.NienKhoa.ReadOnly = true;
            this.NienKhoa.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ KHÓA HỌC";
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 359);
            this.Controls.Add(this.txtNienkhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.txtTenkhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMakhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNienkhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NienKhoa;
        private System.Windows.Forms.Label label1;
    }
}
namespace QLHS
{
    partial class frmLop
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
            this.cmdHienTatCa = new System.Windows.Forms.Button();
            this.cboKhoaTim = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGVCN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHienTatCa
            // 
            this.cmdHienTatCa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHienTatCa.Location = new System.Drawing.Point(353, 63);
            this.cmdHienTatCa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdHienTatCa.Name = "cmdHienTatCa";
            this.cmdHienTatCa.Size = new System.Drawing.Size(133, 29);
            this.cmdHienTatCa.TabIndex = 60;
            this.cmdHienTatCa.Text = "Hiện toàn bộ";
            this.cmdHienTatCa.UseVisualStyleBackColor = true;
            this.cmdHienTatCa.Click += new System.EventHandler(this.cmdHienTatCa_Click);
            // 
            // cboKhoaTim
            // 
            this.cboKhoaTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaTim.FormattingEnabled = true;
            this.cboKhoaTim.Location = new System.Drawing.Point(156, 66);
            this.cboKhoaTim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboKhoaTim.Name = "cboKhoaTim";
            this.cboKhoaTim.Size = new System.Drawing.Size(170, 26);
            this.cboKhoaTim.TabIndex = 59;
            this.cboKhoaTim.SelectedIndexChanged += new System.EventHandler(this.cboKhoaTim_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(551, 552);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(212, 27);
            this.txtSDT.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 555);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "SĐT : ";
            // 
            // txtGVCN
            // 
            this.txtGVCN.Location = new System.Drawing.Point(551, 505);
            this.txtGVCN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(212, 27);
            this.txtGVCN.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 512);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "GVCN : ";
            // 
            // cboNganh
            // 
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganh.FormattingEnabled = true;
            this.cboNganh.Location = new System.Drawing.Point(247, 552);
            this.cboNganh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(183, 26);
            this.cboNganh.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 552);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ngành : ";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(247, 509);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(183, 26);
            this.cboKhoa.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "QUẢN LÝ DANH MỤC LỚP";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // GVCN
            // 
            this.GVCN.DataPropertyName = "GVCN";
            this.GVCN.HeaderText = "GVCN";
            this.GVCN.Name = "GVCN";
            this.GVCN.ReadOnly = true;
            this.GVCN.Width = 150;
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Ngành";
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Chọn khóa :";
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Khóa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(664, 607);
            this.cmdKhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(99, 34);
            this.cmdKhong.TabIndex = 49;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(519, 607);
            this.cmdGhi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(102, 34);
            this.cmdGhi.TabIndex = 48;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(387, 607);
            this.cmdXoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(93, 34);
            this.cmdXoa.TabIndex = 47;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(259, 607);
            this.cmdSua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(91, 34);
            this.cmdSua.TabIndex = 46;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(139, 607);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(91, 34);
            this.cmdThem.TabIndex = 45;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // lblThongbao
            // 
            this.lblThongbao.Location = new System.Drawing.Point(416, 382);
            this.lblThongbao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(347, 33);
            this.lblThongbao.TabIndex = 50;
            this.lblThongbao.Text = ".";
            this.lblThongbao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(247, 460);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(516, 27);
            this.txtTenLop.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên lớp :";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(247, 419);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(516, 27);
            this.txtMaLop.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mã lớp :";
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.MaKhoa,
            this.MaNganh,
            this.GVCN,
            this.SDT});
            this.dgDanhMuc.Location = new System.Drawing.Point(30, 113);
            this.dgDanhMuc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(844, 265);
            this.dgDanhMuc.TabIndex = 39;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 508);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Khóa học :";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 659);
            this.Controls.Add(this.cmdHienTatCa);
            this.Controls.Add(this.cboKhoaTim);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGVCN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNganh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdHienTatCa;
        private System.Windows.Forms.ComboBox cboKhoaTim;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGVCN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.Label label4;
    }
}
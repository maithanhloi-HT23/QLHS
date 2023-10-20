namespace QLHS
{
    partial class frmSinhVien
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
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLopTim = new System.Windows.Forms.ComboBox();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdXuatExcel = new System.Windows.Forms.Button();
            this.cmdThemExcel = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgDanhMuc.Location = new System.Drawing.Point(25, 68);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(688, 498);
            this.dgDanhMuc.TabIndex = 0;
            this.dgDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDanhMuc_CellContentClick);
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSV";
            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaLop";
            this.Column8.HeaderText = "Mã Lớp";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoTen";
            this.Column3.HeaderText = "Họ tên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GioiTinh";
            this.Column5.HeaderText = "Giới tính";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "SĐT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp  :";
            // 
            // cboLopTim
            // 
            this.cboLopTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopTim.FormattingEnabled = true;
            this.cboLopTim.Location = new System.Drawing.Point(141, 20);
            this.cboLopTim.Name = "cboLopTim";
            this.cboLopTim.Size = new System.Drawing.Size(325, 26);
            this.cboLopTim.TabIndex = 2;
            this.cboLopTim.SelectedIndexChanged += new System.EventHandler(this.cboLopTim_SelectedIndexChanged);
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Location = new System.Drawing.Point(699, 28);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(14, 18);
            this.lblThongbao.TabIndex = 3;
            this.lblThongbao.Text = ".";
            this.lblThongbao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã SV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lớp :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giới tính :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "SĐT :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Địa chỉ :";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(855, 100);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(383, 27);
            this.txtMaSV.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(855, 142);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(383, 27);
            this.txtHoTen.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(859, 331);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(383, 27);
            this.txtSDT.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(859, 386);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(383, 27);
            this.txtDiaChi.TabIndex = 16;
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(859, 190);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(379, 26);
            this.cboLop.TabIndex = 17;
            // 
            // optNam
            // 
            this.optNam.AutoSize = true;
            this.optNam.Location = new System.Drawing.Point(870, 288);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(63, 22);
            this.optNam.TabIndex = 18;
            this.optNam.Text = "Nam";
            this.optNam.UseVisualStyleBackColor = true;
            // 
            // optNu
            // 
            this.optNu.AutoSize = true;
            this.optNu.Location = new System.Drawing.Point(1000, 288);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(49, 22);
            this.optNu.TabIndex = 19;
            this.optNu.Text = "Nữ";
            this.optNu.UseVisualStyleBackColor = true;
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(1162, 463);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(94, 29);
            this.cmdKhong.TabIndex = 24;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(1062, 463);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(88, 28);
            this.cmdGhi.TabIndex = 23;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(963, 460);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(86, 31);
            this.cmdXoa.TabIndex = 22;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(855, 460);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(92, 31);
            this.cmdSua.TabIndex = 21;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(744, 460);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(94, 31);
            this.cmdThem.TabIndex = 20;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdXuatExcel
            // 
            this.cmdXuatExcel.Location = new System.Drawing.Point(1030, 518);
            this.cmdXuatExcel.Name = "cmdXuatExcel";
            this.cmdXuatExcel.Size = new System.Drawing.Size(199, 39);
            this.cmdXuatExcel.TabIndex = 27;
            this.cmdXuatExcel.Text = "Xuất danh sách";
            this.cmdXuatExcel.UseVisualStyleBackColor = true;
            this.cmdXuatExcel.Click += new System.EventHandler(this.cmdXuatExcel_Click);
            // 
            // cmdThemExcel
            // 
            this.cmdThemExcel.Location = new System.Drawing.Point(753, 518);
            this.cmdThemExcel.Name = "cmdThemExcel";
            this.cmdThemExcel.Size = new System.Drawing.Size(218, 39);
            this.cmdThemExcel.TabIndex = 26;
            this.cmdThemExcel.Text = "Thêm sinh viên từ Excel";
            this.cmdThemExcel.UseVisualStyleBackColor = true;
            this.cmdThemExcel.Click += new System.EventHandler(this.cmdThemExcel_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(859, 240);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(379, 27);
            this.txtNgaySinh.TabIndex = 28;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 596);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.cmdXuatExcel);
            this.Controls.Add(this.cmdThemExcel);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.optNu);
            this.Controls.Add(this.optNam);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.cboLopTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDanhMuc);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLopTim;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button cmdXuatExcel;
        private System.Windows.Forms.Button cmdThemExcel;
        private System.Windows.Forms.TextBox txtNgaySinh;
    }
}
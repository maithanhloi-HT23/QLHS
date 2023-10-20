namespace QLHS
{
    partial class frmKetQua
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dgKetQua = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHS1 = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtHS2 = new System.Windows.Forms.TextBox();
            this.txtDiemThiLai = new System.Windows.Forms.TextBox();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdThemExcel = new System.Windows.Forms.Button();
            this.cmdXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Lớp :";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(145, 10);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(256, 26);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // dgKetQua
            // 
            this.dgKetQua.AllowUserToAddRows = false;
            this.dgKetQua.AllowUserToDeleteRows = false;
            this.dgKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgKetQua.Location = new System.Drawing.Point(709, 135);
            this.dgKetQua.Name = "dgKetQua";
            this.dgKetQua.ReadOnly = true;
            this.dgKetQua.Size = new System.Drawing.Size(609, 282);
            this.dgKetQua.TabIndex = 5;
            this.dgKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKetQua_CellContentClick);
            this.dgKetQua.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKetQua_CellMouseClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "Ma SV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaMon";
            this.Column9.HeaderText = "Mã môn";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DiemHS1";
            this.Column10.HeaderText = "Điểm HS 1";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "DiemHS2";
            this.Column11.HeaderText = "Điểm HS 2";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DiemThi";
            this.Column12.HeaderText = "DiemThi";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DiemThiLai";
            this.Column13.HeaderText = "Điểm Thi Lại";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Location = new System.Drawing.Point(374, 586);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(283, 38);
            this.lblThongBao.TabIndex = 4;
            this.lblThongBao.Text = ".";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(819, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "BẢNG KẾT QUẢN HỌC TẬP";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(1248, 447);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(20, 18);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = " .";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(709, 93);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(230, 27);
            this.txtMaSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(957, 93);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(343, 27);
            this.txtHoTen.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Môn :";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(806, 439);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(255, 26);
            this.cboMonHoc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = " Hệ số 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Điểm thi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1042, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hệ số 2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1042, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Điểm thi lại :";
            // 
            // txtHS1
            // 
            this.txtHS1.Location = new System.Drawing.Point(806, 488);
            this.txtHS1.Name = "txtHS1";
            this.txtHS1.Size = new System.Drawing.Size(100, 27);
            this.txtHS1.TabIndex = 15;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(809, 533);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(100, 27);
            this.txtDiemThi.TabIndex = 16;
            // 
            // txtHS2
            // 
            this.txtHS2.Location = new System.Drawing.Point(1168, 482);
            this.txtHS2.Name = "txtHS2";
            this.txtHS2.Size = new System.Drawing.Size(100, 27);
            this.txtHS2.TabIndex = 17;
            // 
            // txtDiemThiLai
            // 
            this.txtDiemThiLai.Location = new System.Drawing.Point(1168, 542);
            this.txtDiemThiLai.Name = "txtDiemThiLai";
            this.txtDiemThiLai.Size = new System.Drawing.Size(100, 27);
            this.txtDiemThiLai.TabIndex = 18;
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(713, 586);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(114, 40);
            this.cmdThem.TabIndex = 19;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(838, 586);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(103, 40);
            this.cmdSua.TabIndex = 20;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(947, 586);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(114, 40);
            this.cmdXoa.TabIndex = 21;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(1077, 586);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(103, 40);
            this.cmdGhi.TabIndex = 22;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(1186, 586);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(114, 40);
            this.cmdKhong.TabIndex = 23;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
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
            this.dgDanhMuc.Location = new System.Drawing.Point(12, 93);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(673, 476);
            this.dgDanhMuc.TabIndex = 2;
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
            // cmdThemExcel
            // 
            this.cmdThemExcel.Location = new System.Drawing.Point(766, 642);
            this.cmdThemExcel.Name = "cmdThemExcel";
            this.cmdThemExcel.Size = new System.Drawing.Size(225, 55);
            this.cmdThemExcel.TabIndex = 24;
            this.cmdThemExcel.Text = "Thêm điểm từ Excel";
            this.cmdThemExcel.UseVisualStyleBackColor = true;
            this.cmdThemExcel.Click += new System.EventHandler(this.cmdThemExcel_Click);
            // 
            // cmdXuatExcel
            // 
            this.cmdXuatExcel.Location = new System.Drawing.Point(1029, 642);
            this.cmdXuatExcel.Name = "cmdXuatExcel";
            this.cmdXuatExcel.Size = new System.Drawing.Size(208, 55);
            this.cmdXuatExcel.TabIndex = 25;
            this.cmdXuatExcel.Text = "Xuất bảng điểm";
            this.cmdXuatExcel.UseVisualStyleBackColor = true;
            this.cmdXuatExcel.Click += new System.EventHandler(this.cmdXuatExcel_Click);
            // 
            // frmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 720);
            this.Controls.Add(this.cmdXuatExcel);
            this.Controls.Add(this.cmdThemExcel);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtDiemThiLai);
            this.Controls.Add(this.txtHS2);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtHS1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.dgKetQua);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKetQua";
            this.Load += new System.EventHandler(this.frmKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.DataGridView dgKetQua;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHS1;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtHS2;
        private System.Windows.Forms.TextBox txtDiemThiLai;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button cmdThemExcel;
        private System.Windows.Forms.Button cmdXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
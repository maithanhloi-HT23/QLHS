namespace QLHS
{
    partial class frmChuyenNganh
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
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManganh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTennganh = new System.Windows.Forms.TextBox();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHUYÊN NGÀNH";
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh});
            this.dgDanhMuc.Location = new System.Drawing.Point(8, 48);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(584, 150);
            this.dgDanhMuc.TabIndex = 1;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã ngành";
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.ReadOnly = true;
            this.MaNganh.Width = 150;
            // 
            // TenNganh
            // 
            this.TenNganh.DataPropertyName = "TenNganh";
            this.TenNganh.HeaderText = "Tên ngành";
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.ReadOnly = true;
            this.TenNganh.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ngành :";
            // 
            // txtManganh
            // 
            this.txtManganh.Location = new System.Drawing.Point(136, 216);
            this.txtManganh.Name = "txtManganh";
            this.txtManganh.Size = new System.Drawing.Size(176, 27);
            this.txtManganh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên ngành :";
            // 
            // txtTennganh
            // 
            this.txtTennganh.Location = new System.Drawing.Point(136, 256);
            this.txtTennganh.Name = "txtTennganh";
            this.txtTennganh.Size = new System.Drawing.Size(448, 27);
            this.txtTennganh.TabIndex = 5;
            // 
            // lblThongbao
            // 
            this.lblThongbao.Location = new System.Drawing.Point(384, 208);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(208, 24);
            this.lblThongbao.TabIndex = 6;
            this.lblThongbao.Text = ".";
            this.lblThongbao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblThongbao.Click += new System.EventHandler(this.lblThongbao_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(104, 296);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(104, 32);
            this.cmdThem.TabIndex = 7;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(216, 296);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(88, 32);
            this.cmdSua.TabIndex = 8;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(312, 296);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(88, 32);
            this.cmdXoa.TabIndex = 9;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(408, 296);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(88, 32);
            this.cmdGhi.TabIndex = 10;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(504, 296);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(88, 32);
            this.cmdKhong.TabIndex = 11;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // frmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 350);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.txtTennganh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManganh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChuyenNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenNganh";
            this.Load += new System.EventHandler(this.frmChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTennganh;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdKhong;
    }
}
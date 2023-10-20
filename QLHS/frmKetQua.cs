using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmKetQua : Form
    {
        SqlConnection conn;
        SqlDataAdapter daLop, da, daKetQua, daMonHoc;
        DataTable dt, dtLop, dtKetQua, dtMonHoc;
        DataGridViewCellMouseEventArgs vt;
        bool ktThem;
        string sql = "", macu = "", masv = "", malop = "";

        public frmKetQua()
        {
            InitializeComponent();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            conn = KetNoi.ConnectDB();
            LayNguonChoCBOLop();
            laynguonMonHoc();
            KhoaMo(true);
        }

        public void LayNguonChoCBOLop()
        {
            sql = "Select * from Lop";
            daLop = new SqlDataAdapter(sql, conn);
            dtLop = new DataTable();
            daLop.Fill(dtLop);

            cboLop.DataSource = dtLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }


        public void LayNguonSV()
        {
            if (malop == "") return;
            sql = "Select * from SinhVien where MaLop= N'" + malop + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dgDanhMuc.DataSource = dt;
            lblThongBao.Text = "Có " + dgDanhMuc.RowCount + " sinh viên.";

        }       

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            malop = cboLop.SelectedValue.ToString();
            LayNguonSV();
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            masv = txtMaSV.Text;
            try
            {
                if (dgDanhMuc.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                        txtMaSV.Text = row.Cells[0].Value.ToString();
                        txtHoTen.Text = row.Cells[2].Value.ToString();
                        xoatrang();
                        laynguonKetQua();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Lỗi phát sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                     
        }


        public void laynguonKetQua()
        {
            masv = txtMaSV.Text;
            if (masv == "") return;
            sql = "select * from KetQua where MaSV = N'" + masv + "'";
            daKetQua = new SqlDataAdapter(sql, conn);
            dtKetQua = new DataTable();
            daKetQua.Fill(dtKetQua);

            dgKetQua.DataSource = dtKetQua;
            lblKetQua.Text = "Có " + dgKetQua.RowCount + " điểm môn.";

        }

        public void laynguonMonHoc()
        {
            sql = "Select * From MonHoc";
            daMonHoc = new SqlDataAdapter(sql, conn);
            dtMonHoc = new DataTable();
            daMonHoc.Fill(dtMonHoc);

            cboMonHoc.DataSource = dtMonHoc;
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "MaMon";
        }


        private void dgKetQua_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgKetQua.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgKetQua.Rows[e.RowIndex];
                        cboMonHoc.SelectedValue = row.Cells[1].Value.ToString();
                        txtHS1.Text = Double.Parse(row.Cells[2].Value.ToString()) >= 0 ? row.Cells[2].Value.ToString() : "";
                        txtHS2.Text = Double.Parse(row.Cells[3].Value.ToString()) >= 0 ? row.Cells[3].Value.ToString() : "";
                        txtDiemThi.Text = Double.Parse(row.Cells[4].Value.ToString()) >= 0 ? row.Cells[4].Value.ToString() : "";
                        txtDiemThiLai.Text = Double.Parse(row.Cells[5].Value.ToString()) >= 0 ? row.Cells[5].Value.ToString() : "";
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdThemExcel_Click(object sender, EventArgs e)
        {
            frmNhapDiemExcel frm = new frmNhapDiemExcel();
            frm.ShowDialog();
        }

        private void cmdXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgKetQua.RowCount <= 0) return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xuất bảng điểm không?", "Xuất KQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) return;
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "KetQuaHocTap";
                for (int i = 1; i < dgKetQua.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgKetQua.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgKetQua.Rows.Count; i++)
                {
                    for (int j = 0; j < dgKetQua.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgKetQua.Rows[i].Cells[j].Value;
                    }
                }
                workbook.SaveAs("D:\\outputKQ.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void xoatrang()
        {
            txtHS1.Text = "";
            txtHS2.Text = "";
            txtDiemThi.Text = "";
            txtDiemThiLai.Text = "";
        }

        public void KhoaMo(bool b)
        {
            cboLop.Enabled = b;
            dgDanhMuc.Enabled = b;
            dgKetQua.Enabled = b;

            cmdSua.Enabled = b;
            cmdThem.Enabled = b;
            cmdXoa.Enabled = b;
            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;

            cboMonHoc.Enabled = !b;

            txtDiemThi.ReadOnly = b;
            txtDiemThiLai.ReadOnly = b;
            txtHS1.ReadOnly = b;
            txtHS2.ReadOnly = b;
            

        }

        public void laynguonMonThieu()
        {
            sql = "Select * from monhoc where mamon not in (Select mamon from KetQua where MaSV = N'" + masv + "')";
            daMonHoc = new SqlDataAdapter(sql, conn);
            dtMonHoc = new DataTable();
            daMonHoc.Fill(dtMonHoc);


            cboMonHoc.DataSource = dtMonHoc;
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "MaMon";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            laynguonMonThieu();
            xoatrang();
            ktThem = true;
            KhoaMo(false);
            cboMonHoc.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "") return;
            if (txtHS1.Text == "" && txtHS2.Text == "" && txtDiemThi.Text == "" && txtDiemThiLai.Text == "") return;
            macu = txtMaSV.Text;
            KhoaMo(false);
            ktThem = false;
            cboMonHoc.Enabled = false;
            txtMaSV.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "") return;
            if (txtHS1.Text == "" && txtHS2.Text == "" && txtDiemThi.Text == "" && txtDiemThiLai.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa kết quả môn " + cboMonHoc.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from ketqua where masv = N'" + txtMaSV.Text + "' And mamon = N'" + cboMonHoc.SelectedValue.ToString() + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                xoatrang();
                laynguonKetQua();
            }
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            if (ktThem == true) laynguonMonHoc();
            KhoaMo(true);
            dgKetQua_CellMouseClick(sender, vt);
            return;
        }

        public bool ktTrungThem()
        {
            sql = "Select * from ketqua where masv=N'" + txtMaSV.Text + "' and mamon = N'" + cboMonHoc.SelectedValue.ToString() + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtHS1.Text == "" && txtHS2.Text == "" && txtDiemThi.Text == "" && txtDiemThiLai.Text == "") return;

            if (ktThem == true)
            {
                if (ktTrungThem() == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txtHS1.Text == "") txtHS1.Text = "-1";
            if (txtHS2.Text == "") txtHS2.Text = "-1";
            if (txtDiemThi.Text == "") txtDiemThi.Text = "-1";
            if (txtDiemThiLai.Text == "") txtDiemThiLai.Text = "-1";

            if (ktThem == true)
                sql = "insert into ketqua(masv,mamon,DiemHS1,DiemHS2,DiemThi,DiemThiLai) values(N'" + txtMaSV.Text +
                    "',N'" + cboMonHoc.SelectedValue.ToString() + "'," + Double.Parse(txtHS1.Text) +
                    "," + Double.Parse(txtHS2.Text) + "," + Double.Parse(txtDiemThi.Text) +
                    "," + Double.Parse(txtDiemThiLai.Text) + ")";
            else
                sql = "update sinhvien set DiemHS1=" + Double.Parse(txtHS1.Text) + ", DiemHS2=" + Double.Parse(txtHS2.Text) +
                    ", DiemThi= " + Double.Parse(txtDiemThi.Text) + ",DiemThiLai=" + Double.Parse(txtDiemThiLai.Text) +
                    " Where masv=N'" + txtMaSV.Text + "' and mamon = N'" + cboMonHoc.SelectedValue.ToString() + "'";

            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            if (ktThem == true) laynguonMonHoc();
            KhoaMo(true);
            laynguonKetQua();
        }
    }
}

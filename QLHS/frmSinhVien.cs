using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmSinhVien : Form
    {
        SqlConnection conn;
        SqlDataAdapter daLop, da;
        DataTable dtLop, dt;
        string sql = "";

        SqlDataAdapter daSV;
        DataTable dtSV;
        string maloptim = "";
        DateTime dTest;


        DataGridViewCellMouseEventArgs vt;
        public frmSinhVien()
        {
            InitializeComponent();
        }

         public void KhoaMo(bool b)
        {
            txtMaSV.ReadOnly = b;
            txtHoTen.ReadOnly = b;
            txtNgaySinh.ReadOnly = b;
            txtSDT.ReadOnly = b;
            txtDiaChi.ReadOnly = b;

            dgDanhMuc.Enabled = b;

            cboLopTim.Enabled = b;

            optNam.Enabled = !b;
            optNu.Enabled = !b;

            cmdThem.Enabled = b;
            cmdXoa.Enabled = b;
            cmdSua.Enabled = b;
            cmdKhong.Enabled = !b;
            cmdGhi.Enabled = !b;

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            conn = KetNoi.ConnectDB();
            laynguonCBOLOP();
            KhoaMo(true);
        }

        public void laynguonCBOLOP()
        {
            sql = "Select * From Lop";
            daLop = new SqlDataAdapter(sql, conn);
            dtLop = new DataTable();
            daLop.Fill(dtLop);

            cboLopTim.DataSource = dtLop;
            cboLopTim.DisplayMember = "TenLop";
            cboLopTim.ValueMember = "MaLop";

            cboLop.DataSource = dtLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        public void laynguonsv()
        {
            sql = "select * from sinhvien where malop =N'" + maloptim + "'";
            daSV = new SqlDataAdapter(sql, conn);
            dtSV = new DataTable();
            daSV.Fill(dtSV);
            dgDanhMuc.DataSource = dtSV;
            lblThongbao.Text = "Có " + dgDanhMuc.RowCount + " sinh viên.";
        }

        private void cboLopTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maloptim = cboLopTim.SelectedValue.ToString();
                laynguonsv();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Lỗi phát sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
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
                        DateTime dtNS = (DateTime) row.Cells[3].Value;
                        txtNgaySinh.Text = dtNS.ToString("MM/dd/yyyy");
                        if (Boolean.Parse(row.Cells[4].Value.ToString()) == true)
                            optNam.Checked = true;
                        else
                            optNu.Checked = true;
                        txtSDT.Text = row.Cells[5].Value.ToString();
                        txtDiaChi.Text = row.Cells[6].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Lỗi phát sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ktThem = true;
        string macu = "";

        public void xoatrang()
        {
            txtMaSV.Text = "" ;
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            xoatrang();
            ktThem = true;
            KhoaMo(false);
            txtMaSV.Focus();

        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "") return;
            macu = txtMaSV.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaSV.Focus();

        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa sinh viên " + txtHoTen.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from sinhvien where masv = N'" + txtMaSV.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                xoatrang();
                laynguonsv();
            }

        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            dgDanhMuc_CellMouseClick(sender, vt);
            return;
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            //kiểm tra dữ liệu rỗng 
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã SV.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaSV.Focus(); return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập họ tên SV.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHoTen.Focus(); return;
            }
            if (cboLop.Text == "")
            {
                MessageBox.Show("Chưa chọn lớp cho sv.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboLop.Focus(); return;
            }
            //kiểm tra kiểu dữ liệu (ngày, [số], [bit]…)
            //DateTime dTest;
            if (txtNgaySinh.Text != "")
            {
                if (DateTime.TryParseExact(txtNgaySinh.Text, "MM/dd/yyyy", null, DateTimeStyles.None, out dTest) == false)
                {
                    MessageBox.Show("Nhập sai kiểu ngày tháng.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNgaySinh.Focus();
                    return;
                }
            }
            //kiểm tra trùng mã 
            if (ktThem == true)
            {
                if (ktTrungThem(txtMaSV.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaSV.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            String dateInString = "";
            if (txtNgaySinh.Text != "")
            {
                dTest = DateTime.Parse(txtNgaySinh.Text);
                dateInString = dTest.ToString("MM/dd/yyyy");
            }
            if (ktThem == true)
                sql = "insert into sinhvien(masv,malop,hoten,ngaysinh,gioitinh,sdt,diachi) values(N'" + txtMaSV.Text + "',N'" + cboLop.SelectedValue.ToString() + "',N'" + txtHoTen.Text + "','" +
dateInString + "'," + (optNam.Checked == true ? 1 : 0) + ",N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "')";
            else
                sql = "update sinhvien set masv=N'" + txtMaSV.Text +
                    "',malop=N'" + cboLop.SelectedValue.ToString() + "',hoten=N'" + txtHoTen.Text +
                    "',ngaysinh='" + dateInString + "',gioitinh=" + (optNam.Checked == true ? 1 : 0) +
                    ",sdt=N'" + txtSDT.Text + "',diachi=N'" + txtDiaChi.Text + "' where masv=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            laynguonsv();

        }

        private void cmdThemExcel_Click(object sender, EventArgs e)
        {
            NhapSinhVienTuExcel frm = new NhapSinhVienTuExcel();
            frm.ShowDialog();
        }

        private void cmdXuatExcel_Click(object sender, EventArgs e)
        {
            //bool blTest;
            if (dgDanhMuc.RowCount <= 0) return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xuất danh sach sinh viên lớp "+cboLop.SelectedValue.ToString() +" không?", "Xuất KQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) return;
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = maloptim;
                for (int i = 1; i < dgDanhMuc.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgDanhMuc.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgDanhMuc.Rows.Count; i++)
                {
                    for (int j = 0; j < dgDanhMuc.Columns.Count; j++)
                    {                                             
                        worksheet.Cells[i + 2, j + 1] = dgDanhMuc.Rows[i].Cells[j].Value;
                    }    
                }
                workbook.SaveAs("D:\\Tai_Lieu\\C#\\outputDSSVLop" + maloptim + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from SinhVien where masv=N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from SinhVien where masv=N'" + manhap + "' and masv<> N'" + macu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}

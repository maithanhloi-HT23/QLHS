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
    public partial class frmLop : Form
    {
        SqlConnection conn;
        SqlDataAdapter da, daKhoaTim, daKhoa, daNganh;
        DataTable dt, dtKhoaTim, dtKhoa, dtNganh;
        bool ktThem = true;
        string macu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        string makhoatim = "";

        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            conn = KetNoi.ConnectDB();
            nguon_combo();
            laynguonKhoaTim();
            makhoatim = "";
            laynguon();
            KhoaMo(true);
        }

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;

            txtMaLop.ReadOnly = b;
            txtTenLop.ReadOnly = b;
            txtGVCN.ReadOnly = b;
            txtSDT.ReadOnly = b;
            cboKhoa.Enabled = !b;
            cboNganh.Enabled = !b;

            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }
        public void laynguonKhoaTim()
        {
            daKhoaTim = new SqlDataAdapter("Select * from Khoa", conn);
            dtKhoaTim = new DataTable();
            daKhoaTim.Fill(dtKhoaTim);

            cboKhoaTim.DataSource = dtKhoaTim;
            cboKhoaTim.DisplayMember = "TenKhoa";
            cboKhoaTim.ValueMember = "MaKhoa";
        }
        public void laynguon()
        {
            if (makhoatim == "")
                sql = "Select * from Lop";
            else
                sql = "Select * from Lop where makhoa = N'" + makhoatim + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dgDanhMuc.DataSource = dt;
            lblThongbao.Text = "Có " + (dgDanhMuc.RowCount) + " lớp.";
        }

        public void nguon_combo()
        {
            daKhoa = new SqlDataAdapter("Select * from Khoa", conn);
            dtKhoa = new DataTable();
            daKhoa.Fill(dtKhoa);

            cboKhoa.DataSource = dtKhoa;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";

            daNganh = new SqlDataAdapter("Select * from ChuyenNganh", conn);
            dtNganh = new DataTable();
            daNganh.Fill(dtNganh);

            cboNganh.DataSource = dtNganh;
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
        }

        public void xoatrang()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtGVCN.Text = "";
            txtSDT.Text = "";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            xoatrang();
            ktThem = true;
            KhoaMo(false);
            txtMaLop.Focus();
            
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "") return;
            macu = txtMaLop.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaLop.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa lớp học " + txtTenLop.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from lop where malop = N'" + txtMaLop.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                xoatrang();
                laynguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                txtMaLop.Focus(); return;
            }
            if (txtTenLop.Text == "")
            {
                txtTenLop.Focus(); return;
            }
            if (cboKhoa.Text == "")
            {
                cboKhoa.Focus(); return;
            }
            if (cboNganh.Text == "")
            {
                cboNganh.Focus(); return;
            }
            if (ktThem == true)
            {
                if (ktTrungThem(txtMaLop.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaLop.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (ktThem == true)
                sql = "insert into lop(malop,makhoa,manganh,tenlop,gvcn,sdt) values(N'"
                         + txtMaLop.Text + "',N'" + cboKhoa.SelectedValue.ToString() + "',N'" + cboNganh.SelectedValue.ToString()
                         + "',N'" + txtTenLop.Text + "',N'" + txtGVCN.Text + "',N'" + txtSDT.Text + "')";
            else
                sql = "update lop set malop=N'" + txtMaLop.Text + "', tenlop=N'" + txtTenLop.Text
                    + "',makhoa=N'" + cboKhoa.SelectedValue.ToString() + "', manganh=N'" + cboNganh.SelectedValue.ToString()
                    + "',gvcn=N'" + txtGVCN.Text + "',sdt=N'" + txtSDT.Text + "' where malop=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            laynguon();
        }
        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from lop where malop=N'" + manhap + "'";
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
            sql = "Select * from lop where malop =N'" + manhap + "' and malop<> N'" + macu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            dgDanhMuc_CellMouseClick(sender, vt);
            return;
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
                        txtMaLop.Text = row.Cells[0].Value.ToString();
                        txtTenLop.Text = row.Cells[3].Value.ToString();
                        cboKhoa.SelectedValue = row.Cells[1].Value.ToString();
                        cboNganh.SelectedValue = row.Cells[2].Value.ToString();
                        txtGVCN.Text = row.Cells[4].Value.ToString();
                        txtSDT.Text = row.Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdHienTatCa_Click(object sender, EventArgs e)
        {
            makhoatim = "";
            laynguon();
        }

        private void cboKhoaTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                makhoatim = cboKhoaTim.SelectedValue.ToString();
                laynguon();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

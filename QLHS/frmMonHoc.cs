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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool ktThem = true;
        string macu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";

        public void laynguon()
        {
            da = new SqlDataAdapter("Select * From MonHoc", conn);
            dt = new DataTable();
            da.Fill(dt);

            dgDanhMuc.DataSource = dt;
            lblThongbao.Text = "Có " + (dgDanhMuc.RowCount) + " môn học.";
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
                        txtMaMon.Text = row.Cells[0].Value.ToString();
                        txtTenMon.Text = row.Cells[1].Value.ToString();
                        txtSoTiet.Text = row.Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            conn = KetNoi.ConnectDB();
            laynguon();
            KhoaMo(true);
        }

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;

            txtMaMon.ReadOnly = b;
            txtTenMon.ReadOnly = b;
            txtSoTiet.ReadOnly = b;

            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtSoTiet.Text = "";
            ktThem = true;
            KhoaMo(false);
            txtMaMon.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "") return;
            macu = txtMaMon.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaMon.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa môn học " + txtTenMon.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from monhoc where mamon = N'" + txtMaMon.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtMaMon.Text = "";
                txtTenMon.Text = "";
                txtSoTiet.Text = "";
                laynguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "")
            {
                txtMaMon.Focus(); return;
            }
            if (txtTenMon.Text == "")
            {
                txtTenMon.Focus(); return;
            }
            if (txtSoTiet.Text == "")
            {
                txtSoTiet.Focus(); return;
            }
            if (ktThem == true)
            {
                if (ktTrungThem(txtMaMon.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaMon.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (ktThem == true)
                sql = "insert into monhoc(mamon,tenmon,sotiet) values(N'" + txtMaMon.Text + "',N'" + txtTenMon.Text + "'," + txtSoTiet.Text + ")";
            else
                sql = "update monhoc set mamon=N'" + txtMaMon.Text + "', tenmon=N'" + txtTenMon.Text + "',sotiet=" + txtSoTiet.Text + " where mamon=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            laynguon();
        }

        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from monhoc where mamon=N'" + manhap + "'";
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
            sql = "Select * from monhoc where mamon =N'" + manhap + "' and mamon<> N'" + macu + "'";
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
    }
}

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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
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

        private void frmKhoa_Load(object sender, EventArgs e)
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

            txtMakhoa.ReadOnly = b;
            txtTenkhoa.ReadOnly = b;
            txtNienkhoa.ReadOnly = b;

            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void laynguon()
        {
            da = new SqlDataAdapter("Select * From Khoa", conn);
            dt = new DataTable();
            da.Fill(dt);

            dgDanhMuc.DataSource = dt;
            lblThongbao.Text = "Có " + (dgDanhMuc.RowCount) + " khóa.";
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
                        txtMakhoa.Text = row.Cells[0].Value.ToString();
                        txtTenkhoa.Text = row.Cells[1].Value.ToString();
                        txtNienkhoa.Text = row.Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            txtMakhoa.Text = "";
            txtTenkhoa.Text = "";
            txtNienkhoa.Text = "";
            ktThem = true;
            KhoaMo(false);
            txtMakhoa.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "") return;
            macu = txtMakhoa.Text;
            ktThem = false;
            KhoaMo(false);
            txtMakhoa.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa khóa học " + txtTenkhoa.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from khoa where makhoa = N'" + txtMakhoa.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtMakhoa.Text = "";
                txtTenkhoa.Text = "";
                txtNienkhoa.Text = "";
                laynguon();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMakhoa.Text == "")
            {
                txtMakhoa.Focus(); return;
            }
            if (txtTenkhoa.Text == "")
            {
                txtTenkhoa.Focus(); return;
            }
            if (txtNienkhoa.Text == "")
            {
                txtNienkhoa.Focus(); return;
            }
            if (ktThem == true)
            {
                if (ktTrungThem(txtMakhoa.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMakhoa.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (ktThem == true)
                sql = "insert into khoa(makhoa,tenkhoa,nienkhoa) values(N'" + txtMakhoa.Text + "',N'" + txtTenkhoa.Text + "',N'" + txtNienkhoa.Text + "')";
            else
                sql = "update khoa set makhoa=N'" + txtMakhoa.Text + "', tenkhoa=N'" + txtTenkhoa.Text + "',nienkhoa=N'" + txtNienkhoa.Text + "' where makhoa=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            laynguon();
        }

        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from khoa where makhoa=N'" + manhap + "'";
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
            sql = "Select * from khoa where makhoa =N'" + manhap + "' and makhoa<> N'" + macu + "'";
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

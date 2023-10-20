using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLHS
{
    public partial class frmChuyenNganh : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool ktThem = true;
        string macu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";

        public frmChuyenNganh()
        {
            InitializeComponent();
        }

        private void frmChuyenNganh_Load(object sender, EventArgs e)
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

            txtManganh.ReadOnly = b;
            txtTennganh.ReadOnly = b;

            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void laynguon()
        {
            da = new SqlDataAdapter("Select * From ChuyenNganh", conn);
            dt = new DataTable();
            da.Fill(dt);

            dgDanhMuc.DataSource = dt;
            lblThongbao.Text = "Có " + (dgDanhMuc.RowCount -1) + " chuyên ngành.";
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhMuc.RowCount > 0)
            {
                if (e.RowIndex >= 0)
                {
                    vt = e;
                    DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                    txtManganh.Text = row.Cells[0].Value.ToString();
                    txtTennganh.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            txtManganh.Text = "";
            txtTennganh.Text = "";
            ktThem = true;
            KhoaMo(false);
            txtManganh.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtManganh.Text=="") return;
            macu = txtManganh.Text;
            ktThem = false;
            KhoaMo(false);
            txtManganh.Focus();
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            dgDanhMuc_CellMouseClick(sender, vt);
            return;
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtManganh.Text == "")
            {
                txtManganh.Focus(); return;
            }
            if (txtTennganh.Text == "")
            {
                txtTennganh.Focus(); return;
            }
            if (ktThem == true)
            {
                if (ktTrungThem(txtManganh.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtManganh.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (ktThem == true)
                sql = "insert into chuyennganh(manganh,tennganh) values(N'" + txtManganh.Text + "',N'" + txtTennganh.Text + "')";
            else
                sql = "update chuyennganh set manganh=N'"+ txtManganh.Text +"', tennganh=N'"+ txtTennganh.Text +"' where manganh=N'"+ macu +"'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            laynguon();
        }

        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from chuyennganh where manganh=N'" + manhap + "'";
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
            sql = "Select * from chuyennganh where manganh =N'" + manhap + "' and manganh<> N'" + macu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtManganh.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa chuyên ngành " + txtTennganh.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from chuyennganh where manganh = N'" + txtManganh.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtManganh.Text = "";
                txtTennganh.Text = "";
                laynguon();
            }
        }

        private void lblThongbao_Click(object sender, EventArgs e)
        {

        }
    }
}

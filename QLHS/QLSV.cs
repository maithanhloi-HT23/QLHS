using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuChuyenNganh_Click(object sender, EventArgs e)
        {
            frmChuyenNganh frm = new frmChuyenNganh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
           
        }

        private void hồSơSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kêtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQua frm = new frmKetQua();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

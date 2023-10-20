using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmNhapDiemExcel : Form
    {
        public frmNhapDiemExcel()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        DataSet dsTest = new DataSet();
        string sql;

        private void cmdMoTapTin_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DataRow row;
                        int i, j;
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(ofd.FileName);
                        Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                        Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;
                        int rowCount = excelRange.Rows.Count; //get row count of excel data
                        int colCount = excelRange.Columns.Count; // get column count of excel data
                        for (i = 1; i <= rowCount; i++)
                        {
                            for (j = 1; j <= colCount; j++)
                            {
                                dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                            }
                            break;
                        }
                        int rowCounter;
                        for (i = 2; i <= rowCount; i++)
                        {
                            row = dt.NewRow();
                            rowCounter = 0;
                            for (j = 1; j <= colCount; j++)
                            {
                                if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                                {
                                    row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                                }
                                else
                                {
                                    row[i] = "";
                                }
                                rowCounter++;
                            }
                            dt.Rows.Add(row);
                        }
                        dgDanhMuc.DataSource = dt;
                        excelWorkbook.Close();
                        excelApp.Quit();
                    }
                    catch (Exception ev)
                    {
                        MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmNhapDiemExcel_Load(object sender, EventArgs e)
        {
            conn = KetNoi.ConnectDB();
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (dgDanhMuc.RowCount <= 0) return;
            DialogResult kq = MessageBox.Show("Bạn có muốn ghi kết quả không?", "Ghi KQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) return;

            string masv = "", mamon = "";
            double hs1 = -1, hs2 = -1, dthi = -1, dtl = -1;
            int d = 0;
            for (int i = 0; i < dgDanhMuc.RowCount; i++)
            {
                DataGridViewRow row = dgDanhMuc.Rows[i];
                masv = row.Cells[0].Value.ToString();
                mamon = row.Cells[1].Value.ToString();
                if (ktTrungThem(masv, mamon) == false)
                {
                    hs1 = row.Cells[2].Value.ToString() != "" ? Double.Parse(row.Cells[2].Value.ToString()) : -1;
                    hs2 = row.Cells[3].Value.ToString() != "" ? Double.Parse(row.Cells[3].Value.ToString()) : -1;
                    dthi = row.Cells[4].Value.ToString() != "" ? Double.Parse(row.Cells[4].Value.ToString()) : -1;
                    dtl = row.Cells[4].Value.ToString() != "" ? Double.Parse(row.Cells[5].Value.ToString()) : -1;
                    sql = "Insert into KetQua(MaSV,MaMon,DiemHS1,DiemHS2,DiemThi,DiemThiLai) values(N'" + masv +
                            "',N'" + mamon + "'," + hs1 + "," + hs2 + "," + dthi + "," + dtl + ")";
                    if (conn.State != ConnectionState.Open) conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    d = d + 1;
                }
            }
            MessageBox.Show("Ghi dữ liệu thành công " + d + "/" + dgDanhMuc.RowCount + " dòng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ktTrungThem(string masv, string mamon)
        {
            sql = "Select * from KetQua where MaSV=N'" + masv + "' and MaMon = N'" + mamon + "'";
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QLHS
{
    public partial class NhapSinhVienTuExcel : Form
    {
        public NhapSinhVienTuExcel()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string sql;
        


        private void cmdMoFile_Click(object sender, EventArgs e)
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
                                    dt.Columns.Add(excelRange.Cells[i, j].Value2);                               
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
                                    row[rowCounter] = excelRange.Cells[i, j].Value;
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

        private void NhapSinhVienTuExcel_Load(object sender, EventArgs e)
        {
            conn = KetNoi.ConnectDB();
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (dgDanhMuc.RowCount <= 0) return;
            DialogResult kq = MessageBox.Show("Bạn có muốn ghi kết quả không?", "Ghi KQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) return;

            string masv = "", malop = "", hoten = "", sdt = "", diachi = "", gioitinh = "";             
            string ngaysinh = "";
            int d = 0;
            for (int i = 0; i < dgDanhMuc.RowCount; i++)
            {
                try
                {
                    DataGridViewRow row = dgDanhMuc.Rows[i];
                    masv = row.Cells[0].Value.ToString();
                    malop = row.Cells[1].Value.ToString();
                    if (ktTrungThem(masv, malop) == false)
                    {
                        hoten = row.Cells[2].Value.ToString();
                        //su ly date time   
                        DateTime dTest;
                        string dateString = row.Cells[3].Value.ToString();
                        if (row.Cells[3].Value != null)
                        {
                            dTest = DateTime.Parse(dateString);
                            ngaysinh = dTest.ToString("MM/dd/yyyy");
                        }

                        gioitinh = row.Cells[4].Value.ToString();
                        sdt = row.Cells[5].Value.ToString();
                        diachi = row.Cells[6].Value.ToString();
                        sql = "insert into sinhvien(masv,malop,hoten,ngaysinh,gioitinh,sdt,diachi) values(N'" + masv +
                                "',N'" + malop + "',N'" + hoten + "',N'" + ngaysinh + "'," + (gioitinh.Equals("True") ? 1 : 0) + ",N'" + sdt + "',N'" + diachi + "')";
                        if (conn.State != ConnectionState.Open) conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        d = d + 1;
                    }
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Ghi dữ liệu thành công " + d + "/" + dgDanhMuc.RowCount + " dòng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
                
        public bool ktTrungThem(string masv, string malop)
        {
            sql = "Select * from SinhVien where MaSV=N'" + masv + "' and MaLop = N'" + malop + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}

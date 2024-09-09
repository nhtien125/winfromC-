using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WinFormsApp1
{
    public partial class FormLichSuChamCong : Form
    {

        public int month2 = 0;
        String sqlLoad = null;
        public static DateTime dateTime = DateTime.Now;
        public static String MaNv = adminform.getCurrentID();
        String day = dateTime.ToString("dd");
        String month = dateTime.ToString("MM");
        String year = dateTime.ToString("yyyy");
        public static String ThoiGianCham = dateTime.ToString(@"HH\:mm ");
        public static String NgayCham = dateTime.Date.ToString("yyyy-MM-dd");
        public static DateTime Today = DateTime.Parse(NgayCham);
        public static FormLichSuChamCong guiLSCC;
        public FormLichSuChamCong()
        {
            InitializeComponent();
            guiLSCC = this;
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void InsertList(String datetime)
        {
            //In tất cả id nhân viên khi không tồn tại trong bảng chấm công ngày hôm nay
            String sql2 = @"insert into dbo.tbl_ChamCong(MaNV,NgayCham) Select MaNV,GETDATE() from dbo.tbl_nhanvien where not exists (select * from dbo.tbl_ChamCong where CONVERT(nvarchar,NgayCham,101) = CONVERT(nvarchar,@date,101) and dbo.tbl_nhanvien.MaNV = MaNV)";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@date", SqlDbType.DateTime);
            cmd.Parameters["@date"].Value = datetime;
            Functions.Functions.RunSQL(sql2, cmd);
        }
        private void lblToday_Click(object sender, EventArgs e)
        {
          
            InsertList(DateTime.Now.ToString());
            //Lọc danh sách cán bộ ngày hôm nay
            String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where CONVERT(nvarchar,cc.NgayCham,101) = CONVERT(nvarchar,getdate(),101)";

            loadData(sql);
           
        }

        public void loadData(String sql)
        {
            DataTable data = Functions.Functions.GetDataToTable(sql);
            int i = 1;
            dataChamCong.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                String timeCheckIn = "";
                String timeCheckOut = "";
                String Now = "";
                String note = "";
                if (row[2] != DBNull.Value)
                {
                    Now = row[2].ToString();
                    DateTime dateTime1 = DateTime.Parse(Now);
                    Now = dateTime1.ToString("dd/MM/yyyy");                    
                }
               
                if (row[3] != DBNull.Value)
                {
                    timeCheckIn = row[3].ToString();
                    DateTime dateTime2 = DateTime.Parse(timeCheckIn);
                    timeCheckIn = dateTime2.ToString(@"HH\:mm ");
                    if (row[4] != DBNull.Value)
                    {
                        timeCheckOut = row[4].ToString();
                        DateTime dateTime3 = DateTime.Parse(timeCheckOut);
                        timeCheckOut = dateTime3.ToString(@"HH\:mm ");

                    }
                    else
                    {
                        if (row[4] == DBNull.Value)
                        {
                            note = "Chưa check out!!!";
                        }
                    }
                }
                else
                {
                    note = note + "Chưa chấm công!!!";
                }
                
               
                dataChamCong.Rows.Add(i, row[0], row[1], Now, timeCheckIn, timeCheckOut,row[5] + note);
                i++;
            }
            
        }

        private void dataCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                FormLichSuChamCong_Tool form = new FormLichSuChamCong_Tool();
                form.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataChamCong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormLichSuChamCong_Load(object sender, EventArgs e)
        {
           
        }

        private void dataChamCong_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void OnChange()
        {
            int a = dataChamCong.RowCount;
            lblTongNV.Text = "Tổng nhân viên: " + a;
            int b = 0;
            int c = 0;
            int d = 0;
            foreach (DataGridViewRow row in dataChamCong.Rows)
            {
                if (row.Cells[4].Value == "")
                {
                    b++;
                }
                else
                { c++; }
                if (row.Cells[5].Value == "")
                {
                    d++;
                }
                if (row.Cells[6].Value != "")
                {
                    row.DefaultCellStyle.BackColor = Color.Beige;
                }
            }
            lblTongChuaCC.Text = "Nhân viên chưa chấm công: " + b;
            lblTongCC.Text = "Nhân viên đã chấm công: " + c;
            lblTongMuon.Text = "Nhân viên chưa check out: " + d;
        }

        private void dataChamCong_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            OnChange();
        }

        private void dataChamCong_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            OnChange();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String sreach = textBox1.Text.ToUpper().Trim();
            String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where cc.MaNV = '"+sreach+"'";
            loadData(sql);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

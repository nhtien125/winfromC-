using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class FormChamCong : Form
    {

        public int month2 = 0;
        String sqlLoad = null;
        public static DateTime dateTime = DateTime.Now;
        public String MaNv = adminform.getCurrentID();
        String day = dateTime.ToString("dd");
        String month = dateTime.ToString("MM");
        String year = dateTime.ToString("yyyy");
        public static String dateCham = dateTime.Date.ToString("dd/MM/yyyy");
        public FormChamCong()
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblTime.Text = "Hôm nay là " + Functions.Functions.dateTime();
            loadDataCC(sqlLoad);
            cobLoc.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Hôm nay là " + Functions.Functions.dateTime();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String timeCham = DateTime.Now.ToString("HH:mm");
            DateTime dateTime = DateTime.Now;
            //Câu lệnh chấm công. Nếu tồn tại bảng chấm thì update không có thì thêm
            String sql = @"if not exists (select * from dbo.tbl_ChamCong where MaNV = @MaNV and CONVERT(nvarchar,NgayCham,101) = CONVERT(nvarchar,getdate(),101)) begin INSERT INTO dbo.tbl_ChamCong([MaNV],[NgayCham],[ThoiGianCheckIn])VALUES (@MaNV,@dateCham,@ThoiGianCheckIn) end else begin UPDATE dbo.tbl_ChamCong set ThoiGianCheckIn = @ThoiGianCheckIn where MaNV = @MaNV and CONVERT(nvarchar,NgayCham,101) = CONVERT(nvarchar,@dateCham,101) end";
            String sql2 = "select * from dbo.tbl_ChamCong where DAY(NgayCham) = '"+day+"' and MONTH(NgayCham) = '"+month+"' and MaNV = '"+MaNv+"' and YEAR(NgayCham) = '"+year+"' and ThoiGianCheckIn is not null";       
            if (Functions.Functions.CheckKey(sql2) == true)
            {
                MessageBox.Show("Đã CheckIn ngày hôm nay rồi !!!!!");
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add("@dateCham", SqlDbType.DateTime);
                cmd.Parameters["@dateCham"].Value = dateTime;
                cmd.Parameters.Add("@ThoiGianCheckIn", SqlDbType.DateTime);
                cmd.Parameters["@ThoiGianCheckIn"].Value = timeCham;
                cmd.Parameters.AddWithValue("@MaNV", MaNv);
               // cmd.Parameters.Add("ThoiGianCheckOut", SqlDbType.DateTime);
               // cmd.Parameters["ThoiGianCheckOut"].Value = null;
                Functions.Functions.RunSQL(sql, cmd);
                dataCC.Rows.Clear();
                loadDataCC(sqlLoad);
            }
            

        }

        private void loadDataCC(String sql)
        {
            if (sql == null)
            {
                sql = "Select * From dbo.tbl_ChamCong where MaNV='" + adminform.getCurrentID() + "'";
                this.dataCC.Sort(this.dataCC.Columns[2], ListSortDirection.Ascending);
            }
            DataTable data = Functions.Functions.GetDataToTable(sql);
            DateTime dateTime2 = new DateTime();
            DateTime dateTime3 = new DateTime();
            String gioLam = "";
            dataCC.Rows.Clear();
            int i = 1;
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                   String timeCheckOut = "";
                    String timeCheckIn = "";
                   DateTime dateTime = DateTime.Parse(row[1].ToString());
                    if (row[2] != DBNull.Value)
                    {
                        dateTime2 = DateTime.Parse(row[2].ToString());
                         timeCheckIn = dateTime2.ToString(@"HH\:mm ");
                    }
                    if (row[3] != DBNull.Value)
                    {
                        dateTime3 = DateTime.Parse(row[3].ToString());
                        timeCheckOut = dateTime3.ToString(@"HH\:mm ");
                    }
                    TimeSpan span = dateTime3.Subtract(dateTime2);
                    gioLam = span.Hours.ToString() + " Giờ " + span.Minutes.ToString() + " Phút ";

                    String dateCham = dateTime.Date.ToString("dd/MM/yyyy");
                                       
                    dataCC.Rows.Add(row[0], Functions.Functions.connverter(dateTime), dateCham, timeCheckIn,timeCheckOut,gioLam);
                }
                this.dataCC.Sort(this.dataCC.Columns[2], ListSortDirection.Ascending);
            }
        }        

        private void cobLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = cobLoc.Text;
            switch (selected)
            {
                case "Tháng 1":
                    month2 = 1;
                    break;
                case "Tháng 2":
                    month2 = 2;
                    break;
                case "Tháng 3":
                    month2 = 3;
                    break;
                case "Tháng 4":
                    month2 = 4;
                    break;
                case "Tháng 5":
                    month2 = 5;
                    break;
                case "Tháng 6":
                    month2 = 6;
                    break;
                case "Tháng 7":
                    month2 = 7;
                    break;
                case "Tháng 8":
                    month2 = 8;
                    break;
                case "Tháng 9":
                    month2 = 9;
                    break;
                case "Tháng 10":
                    month2 = 10;
                    break;
                case "Tháng 11":
                    month2 = 11;
                    break;
                case "Tháng 12":
                    month2 = 12;
                    break;
            }
            if (cobLoc.Text == "Chọn tháng")
            {
                loadDataCC(sqlLoad);
            }
            else
            {
                String b = "month" + month2 + "  " + cobLoc.Text;
                lblGioLam.Text = "Số giờ làm tháng " + month2 + " : ";
                String sql = "Select * from dbo.tbl_ChamCong where MONTH(NgayCham) = " + month2 + " and MaNV='" + adminform.getCurrentID() + "'";
                String sql2 = "select  SUM(DATEPART(Hour,ThoiGianCheckOut)) - SUM(DatePart(Hour,ThoiGianCheckIn)) as 'Tong Gio'from dbo.tbl_ChamCong where MaNV = '"+adminform.getCurrentID()+"' and MONTH(NgayCham) = '"+month2+"'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql2;                
                SqlDataReader readder = Functions.Functions.RunSqlwithreturn(sql2,cmd);
                if (readder.Read())
                {
                    if (readder.IsDBNull(0) == false)
                    {
                        txtGioLam.Text = readder.GetInt32(0).ToString();
                    }
                    else
                        txtGioLam.Text = "";
                }
                readder.Close();
                loadDataCC(sql);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String timeCham = DateTime.Now.ToString("HH:mm");
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn check out không? ", "Cảnh Cáo!!!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {              
                String sql1 = "select ThoiGianCheckIn from dbo.tbl_ChamCong where DAY(NgayCham) = '" + day + "' and MONTH(NgayCham) = '" + month + "' and MaNV = '" + MaNv + "' and YEAR(NgayCham) = '" + year + "'";
                if (!Functions.Functions.CheckKey(sql1))
                {
                    MessageBox.Show("Bạn phải check in trước");
                    return;
                }
                else
                {
                    String sql2 = "select ThoiGianCheckOut from dbo.tbl_ChamCong where DAY(NgayCham) = '" + day + "' and MONTH(NgayCham) = '" + month + "' and MaNV = '" + MaNv + "' and YEAR(NgayCham) = '" + year + "' and ThoiGianCheckOut is null";
                    if (!Functions.Functions.CheckKey(sql2))
                    {
                        MessageBox.Show("Đã CheckOut ngày hôm nay rồi !!!!!");
                        return;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        String sql3 = "UPDATE dbo.tbl_ChamCong set ThoiGianCheckOut = @ThoiGianCheckOut where DAY(NgayCham) = '" + day + "' and MONTH(NgayCham) = '" + month + "' and MaNV = '" + MaNv + "' and YEAR(NgayCham) = '" + year + "'";
                        cmd.Parameters.Add("ThoiGianCheckOut", SqlDbType.DateTime);
                        cmd.Parameters["ThoiGianCheckOut"].Value = timeCham;
                        Functions.Functions.RunSQL(sql3,cmd);
                        loadDataCC(sqlLoad);
                    }
                }

            }
        }

    }
}
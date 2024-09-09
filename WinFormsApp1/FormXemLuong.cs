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

namespace WinFormsApp1
{
    public partial class FormXemLuong : Form
    {
        public FormXemLuong()
        {
            InitializeComponent();
        }
        String sqlLoad = null;
        public int month2 = 0;
        private void FormXemLuong_Load(object sender, EventArgs e)
        {
            cbManhanvien.Text = adminform.getCurrentID();
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from dbo.tbl_nhanvien where MaNV = '" + Functions.Functions.getID() + "'";
            SqlDataReader reader = Functions.Functions.RunSqlwithreturn(sql, cmd);
            if (reader.Read())
            {

                String chucvu = reader.GetString(7);
                txtTennhanvien.Text = reader.GetString(1);
                txtLoailuong.Text = reader.GetString(6);
                reader.Close();

            }
            reader.Close();
            SqlCommand cmd1 = new SqlCommand();
            String sql1 = "select * from dbo.tbl_Chitietluong where LoaiLuong = '" +txtLoailuong.Text+"'";
            SqlDataReader reader1 = Functions.Functions.RunSqlwithreturn(sql1, cmd1);
            if (reader1.Read())
            {
                txtLuongthang.Text = reader1.GetInt32(1).ToString();
                reader1.Close();
            }
            reader1.Close();
         
        }
        private void loadDataCC(String sql)
        {
            if (sql == null)
            {
                sql = "Select * From dbo.tbl_ChamCong where MaNV='" + adminform.getCurrentID() + "'";
              
            }
            DataTable data = Functions.Functions.GetDataToTable(sql);
            DateTime dateTime2 = new DateTime();
            DateTime dateTime3 = new DateTime();
            String gioLam = "";
          
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

                }
               
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
               
                String sql = "Select * from dbo.tbl_ChamCong where MONTH(NgayCham) = " + month2 + " and MaNV='" + adminform.getCurrentID() + "'";
                String sql2 = "select  SUM(DATEPART(Hour,ThoiGianCheckOut)) - SUM(DatePart(Hour,ThoiGianCheckIn)) as 'Tong Gio'from dbo.tbl_ChamCong where MaNV = '" + adminform.getCurrentID() + "' and MONTH(NgayCham) = '" + month2 + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql2;
                SqlDataReader readder = Functions.Functions.RunSqlwithreturn(sql2, cmd);
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

        private void label1_Click(object sender, EventArgs e)
        {
           
        
    }

        private void txtGioLam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGioLam.Text != "")
            {
                int t = Int32.Parse(txtLuongthang.Text) * Int32.Parse(txtGioLam.Text);
                txtTongtien.Text = t.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}

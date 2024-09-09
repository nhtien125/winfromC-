using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormLichSuChamCong_Tool : Form
    {
        
        public FormLichSuChamCong_Tool()
        {
            InitializeComponent();
            dtControl.Format = DateTimePickerFormat.Custom;
            dtControl.CustomFormat = " dd /MM /yyyy";
        }

        
       
      
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            FormLichSuChamCong.guiLSCC.InsertList(getTimeControl());
            String sql = @"DECLARE @date datetime Set @date = CONVERT(nvarchar,'"+getTimeControl()+ "',111) Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where CONVERT(nvarchar,cc.NgayCham,111) = @date";
            FormLichSuChamCong.guiLSCC.loadData(sql);
            */
            String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where DAY(cc.NgayCham) = '"+getDayControl()+"' and Month(cc.NgayCham) = '"+getMonthControl()+"' and YEAR(cc.NgayCham) = '"+getYearControl()+"' and ThoiGianCheckIn is null";
            FormLichSuChamCong.guiLSCC.loadData(sql);
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private String getDayControl()
        {
            String dt = dtControl.Value.Date.ToString("dd");   
            return dt;
        }
        private String getMonthControl()
        {
            String dt2 = dtControl.Value.Date.ToString("MM");
            return dt2;
        }
        private String getYearControl()
        {
            String dt3 = dtControl.Value.Date.ToString("yyyy");
            return dt3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where DAY(cc.NgayCham) = '" + getDayControl() + "' and Month(cc.NgayCham) = '" + getMonthControl() + "' and YEAR(cc.NgayCham) = '" + getYearControl() + "'";
            FormLichSuChamCong.guiLSCC.loadData(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where DAY(cc.NgayCham) = '" + getDayControl() + "' and Month(cc.NgayCham) = '" + getMonthControl() + "' and YEAR(cc.NgayCham) = '" + getYearControl() + "' and ThoiGianCheckOut is null";
            //String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where DAY(cc.NgayCham) = '" + getDayControl() + "' and Month(cc.NgayCham) = '" + getMonthControl() + "' and YEAR(cc.NgayCham) = '" + getYearControl() + "' and ThoiGianCheckIn is not null and ThoiGianCheckOut is null";
            FormLichSuChamCong.guiLSCC.loadData(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String sql = @"Select nv.MaNV, nv.TenNV,cc.NgayCham, cc.ThoiGianCheckIn, cc.ThoiGianCheckOut ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV";
            FormLichSuChamCong.guiLSCC.loadData(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sql = @"Select nv.MaNV as 'Mã nhân viên', nv.TenNV as 'Tên nhân viên',CONVERT(nvarchar,cc.NgayCham,103) as 'Ngày chấm', CONVERT(nvarchar,cc.ThoiGianCheckIn,108) as 'Thời gian chấm công' , CONVERT(nvarchar,cc.ThoiGianCheckOut,108) as 'Thời gian check out' ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where DAY(cc.NgayCham) = '" + getDayControl() + "' and Month(cc.NgayCham) = '" + getMonthControl() + "' and YEAR(cc.NgayCham) = '" + getYearControl() + "'";
            Functions.Functions.ExportToExcel(sql);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String sql = @"Select nv.MaNV as 'Mã nhân viên', nv.TenNV as 'Tên nhân viên',CONVERT(nvarchar,cc.NgayCham,103) as 'Ngày chấm', CONVERT(nvarchar,cc.ThoiGianCheckIn,108) as 'Thời gian chấm công' , CONVERT(nvarchar,cc.ThoiGianCheckOut,108) as 'Thời gian check out' ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV ORDER BY NgayCham";
            Functions.Functions.ExportToExcel(sql);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            String a = txtMaNV.Text.Trim();
            String sql2 = @"Select * from dbo.tbl_ChamCong where MaNV = '" + a + "'";
            if (Functions.Functions.CheckKey(sql2))
            {
                String sql = @"Select nv.MaNV as 'Mã nhân viên', nv.TenNV as 'Tên nhân viên',CONVERT(nvarchar,cc.NgayCham,103) as 'Ngày chấm', CONVERT(nvarchar,cc.ThoiGianCheckIn,108) as 'Thời gian chấm công' , CONVERT(nvarchar,cc.ThoiGianCheckOut,108) as 'Thời gian check out' ,cc.Notes from dbo.tbl_nhanvien nv left join dbo.tbl_ChamCong cc on nv.MaNV = cc.MaNV where cc.MaNV = '" + a + "'";
                Functions.Functions.ExportToExcel(sql);
            }
            else
            { MessageBox.Show("Không tồn tại dữ liệu");
            return;}    
        }
    }
}

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
    public partial class FormInDSNV : Form
    {
        public FormInDSNV()
        {
            InitializeComponent();
        }
        string sql1 = @"SELECT [MaNV] as 'Mã nhân viên',[TenNV] as 'Tên Nhân viên',[Giới tính],[DiaChi] as 'Địa chỉ',[DienThoai] as 'Số điện thoại',[NgaySinh] as 'Ngày sinh',[LoaiLuong] as 'Loại lương',[ChucVu] as 'Chức vụ' FROM [dbo].[tbl_nhanvien] where ChucVu = 'nv'";
        String sql2 = @"SELECT [MaNV] as 'Mã nhân viên',[TenNV] as 'Tên Nhân viên',[Giới tính],[DiaChi] as 'Địa chỉ',[DienThoai] as 'Số điện thoại',[NgaySinh] as 'Ngày sinh',[LoaiLuong] as 'Loại lương',[ChucVu] as 'Chức vụ' FROM [dbo].[tbl_nhanvien] where ChucVu = 'ql'";
        String sql3 = @"SELECT [MaNV] as 'Mã nhân viên',[TenNV] as 'Tên Nhân viên',[Giới tính],[DiaChi] as 'Địa chỉ',[DienThoai] as 'Số điện thoại',[NgaySinh] as 'Ngày sinh',[LoaiLuong] as 'Loại lương',[ChucVu] as 'Chức vụ' FROM [dbo].[tbl_nhanvien]";
        String header = "Danh sách nhân sự";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT [MaNV] as 'Mã nhân viên',[TenNV] as 'Tên Nhân viên',[Giới tính],[DiaChi] as 'Địa chỉ',[DienThoai] as 'Số điện thoại',[NgaySinh] as 'Ngày sinh',[LoaiLuong] as 'Loại lương',[ChucVu] as 'Chức vụ' FROM [dbo].[tbl_nhanvien] where ChucVu = 'nv'";
            Functions.Functions.ExportToExcel(sql1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT [MaNV] as 'Mã nhân viên',[TenNV] as 'Tên Nhân viên',[Giới tính],[DiaChi] as 'Địa chỉ',[DienThoai] as 'Số điện thoại',[NgaySinh] as 'Ngày sinh',[LoaiLuong] as 'Loại lương',[ChucVu] as 'Chức vụ' FROM [dbo].[tbl_nhanvien] where ChucVu = 'nv'";
            Functions.Functions.createPDF(sql1,header);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT [MaNV],[TenNV],[Giới tính],[DiaChi],[DienThoai],[NgaySinh],[LoaiLuong],[ChucVu]FROM [dbo].[tbl_nhanvien] where ChucVu = 'ql'";
            Functions.Functions.createPDF(sql2,header);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT [MaNV],[TenNV],[Giới tính],[DiaChi],[DienThoai],[NgaySinh],[LoaiLuong],[ChucVu]FROM [dbo].[tbl_nhanvien] where ChucVu = 'ql'";
            Functions.Functions.ExportToExcel(sql2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT [MaNV],[TenNV],[Giới tính],[DiaChi],[DienThoai],[NgaySinh],[LoaiLuong],[ChucVu]FROM [dbo].[tbl_nhanvien]";
            Functions.Functions.createPDF(sql3, header);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //String sql = "SELECT [MaNV],[TenNV],[Giới tính],[DiaChi],[DienThoai],[NgaySinh],[LoaiLuong],[ChucVu]FROM [dbo].[tbl_nhanvien]";
            Functions.Functions.ExportToExcel(sql3);
        }
    }
}

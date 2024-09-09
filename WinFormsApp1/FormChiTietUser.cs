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
using WinFormsApp1.Functions;

namespace WinFormsApp1
{
    public partial class FormChiTietUser : Form
    {
        public static FormChiTietUser gui;
        public FormChiTietUser()
        {
            InitializeComponent();
            gui = this;
        }

        private void FormChiTietUser_Load(object sender, EventArgs e)
        {
            setLabel();
            loadProfile();
           
            
           this.FormBorderStyle = FormBorderStyle.None;
        }

        public void setLabel()
        {
            //label1.Text = Functions.Functions.getID();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void loadProfile()
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from dbo.tbl_nhanvien where MaNV = '" + Functions.Functions.getID()+ "'";
            SqlDataReader reader = Functions.Functions.RunSqlwithreturn(sql,cmd);            
            if (reader.Read())
                {

                    String chucvu = reader.GetString(7);
                    if (chucvu == "nv")
                    {
                        lblChucVu.Text = "Chức vụ: Nhân Viên";
                    }
                    else
                    lblChucVu.Text = "Chức vụ: Quản lý";
                    lblName.Text = reader.GetString(1);
                    if (reader["Ava"] != DBNull.Value)
                    {
                        Byte[] a = (Byte[])reader["Ava"];
                        picAvaProfile.Image = Image.FromStream(new MemoryStream(a));
                    }
                    lblSdt.Text = lblSdt.Text + reader["DienThoai"];
                    lblDiaChi.Text =lblDiaChi.Text + (String) reader["DiaChi"];
                    lblGioiTinh.Text = lblGioiTinh.Text + reader.GetString(2);
                    lblNgaySinh.Text = lblNgaySinh.Text + reader.GetString(5);
                    lblLoaiLuong.Text = lblLoaiLuong.Text + reader.GetString(6);
                    reader.Close();
                     
                }
            reader.Close();            
        }
    }
}

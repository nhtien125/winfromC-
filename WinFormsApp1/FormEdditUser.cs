using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Functions;

namespace WinFormsApp1
{
    public partial class FormEdditUser : Form
    {

        String[] b = new string[2] { "admin", "nv" };
        String[] a = new String[5] { "loai 1", "loai 2", "loai 3", "loai 4", "ql" };
        public FormEdditUser()
        {
            InitializeComponent();

        }

        private void FormEdditUser_Load(object sender, EventArgs e)
        {

            addUserready();
            dateNgaySinh.CustomFormat = @"dd/MM/yyyy";
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            loadIn4();  

        }

        private void loadIn4()
        {
            String id = Functions.Functions.getID();
            String username = id.ToUpper().Trim();
            username = "@" + username;
            txtUsername.Text = username;
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from dbo.tbl_nhanvien where MaNV = '" + id + "'";
            SqlDataReader reader = Functions.Functions.RunSqlwithreturn(sql, cmd);
            if (reader.Read())
            {
                lblStatus.Text = "Eddit User";
                txtId.Text = reader.GetString(0);
                txtName.Text = reader.GetString(1);
                txtSdt.Text = reader.GetString(4);
                txtDiaChi.Text = reader.GetString(3);
                if (reader["Ava"] != DBNull.Value)
                {
                    Byte[] a = (Byte[])reader["Ava"];
                    picAva.Image = Image.FromStream(new MemoryStream(a));
                }
                String Gender = reader.GetString(2);
                if (Gender.ToLower() == "nam")
                {
                    rdoNam.Checked = true;
                }
                else
                    rdoNu.Checked = true;
                String date = reader.GetString(5);
                dateNgaySinh.Value = DateTime.Parse(date);
                String ChucVu = reader.GetString(7);
                for (int i = 0; i < 2; i++)
                {
                    if (ChucVu == b[i])
                    {
                        cobChucVu.SelectedIndex = i + 1;
                    }
                }
                String LoaiLuong = reader.GetString(6);
                for (int i = 0; i < 5; i++)
                {
                    if (LoaiLuong == a[i])
                    {
                        cobLoaiLuong.SelectedIndex = i + 1;
                    }
                }
                reader.Close();
            }
            reader.Close();
            String sql2 = "select * from dbo.tbl_Account where MaNV = '" + id + "'";
            SqlDataReader reader2 = Functions.Functions.RunSqlwithreturn(sql2, cmd);
            {
                if (reader2.Read())
                {
                    txtPassWord.Text = (String)reader2["Pass"];
                    reader2.Close();
                }
                reader2.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserready()
        {
            cobChucVu.Items.AddRange(b);
            cobLoaiLuong.Items.AddRange(a);
        }
        private String checkBox()
        {
            if (rdoNam.Checked)
            {
                return rdoNam.Text;
            }
            else
                return rdoNu.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassWord.Text = "12345678";
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            picAva.Image = Properties.Resources.d2e922c51bda62ccd55ef2fb872dfa10;
        }

        private void picChosse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;*)|*.jpg;*.jpeg;.*.gif;*.png";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picAva.Image = new Bitmap(opnfd.FileName);
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.PlaceholderText = "Phải nhập";
                txtName.Focus();
            }
            if (txtSdt.Text == "")
            {
                txtSdt.PlaceholderText = "Phải nhập";
                txtSdt.Focus();
            }
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.PlaceholderText = "Phải nhập";
                txtDiaChi.Focus();
            }
            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cobLoaiLuong.Text == "")
            {
                MessageBox.Show("Phải nhập lại lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string a = cobLoaiLuong.Text;
            string b = cobChucVu.Text;
            String sql = "UPDATE dbo.tbl_nhanvien SET TenNV = @TenNV, [Giới tính] = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai, NgaySinh = @NgaySinh, LoaiLuong = @LoaiLuong, ChucVu = @ChucVu, Ava = @image where MaNV = @id ";
            String sql2 = "UPDATE dbo.tbl_Account SET Pass = @pass WHERE MaNV = @id";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@image", SqlDbType.Image);
            cmd.Parameters.AddWithValue("@TenNV", txtName.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", checkBox());
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", txtSdt.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value.Date.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@LoaiLuong", a);
            cmd.Parameters.AddWithValue("@ChucVu", b);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassWord.Text);
            cmd.Parameters["@image"].Value = Functions.Functions.getByteImage(picAva);
            Functions.Functions.RunSQL(sql, cmd);
            Functions.Functions.RunSQL(sql2, cmd);
            Functions.Functions.Disconnect();
            MessageBox.Show("Cập nhập thông tin thành công!");
            return;

        }

        public void UserSetting()
        {
            String role = Functions.Functions.getRoles();
            txtPassWord.ReadOnly = false;
            txtPassWord.Enabled = true;
            checkShowPasss.Enabled = true;
            checkShowPasss.Visible = true;
            if (role == "nv")
            {
              cobChucVu.Enabled = false;
              cobLoaiLuong.Enabled = false;            
            }
        }

        private void showPass()
        {
            if (checkShowPasss.Checked)
            {
                txtPassWord.PasswordChar = '\0';
            }
            else
                txtPassWord.PasswordChar = '*';        
        }

        private void checkShowPasss_CheckedChanged(object sender, EventArgs e)
        {
            showPass();
        }
    }
}

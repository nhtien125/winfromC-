using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Functions;



namespace WinFormsApp1
{
    public partial class FormDSNV1 : Form
    {
        DataTable DSNV;
        String sql;
        private String pass = "12345678";
        public static FormDSNV1 guiDSNV1;
        public FormDSNV1()
        {
            InitializeComponent();
            loadDataToGripView();
            addUserready();
            guiDSNV1 = this;
            dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            dateNgaySinh.Format = DateTimePickerFormat.Custom;

        }

        public void loadDataToGripView()
        {
            String sql = "Select * From dbo.tbl_nhanvien where ChucVu='nv'";
            DSNV = Functions.Functions.GetDataToTable(sql);
            int i = 1;


            foreach (DataRow row in DSNV.Rows)
            {

                dataDSNV1.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                i++;
            }
            dataDSNV1.Enabled = true;
        }

        private void dataDSNV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDSNV1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panel_Adduser.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtId.Text.Trim().Length == 0)
            {
                txtId.PlaceholderText = "Phải nhập!";
            }
            else
            {
                sql = "select * from dbo.tbl_nhanvien where MaNV = '" + txtId.Text.Trim() + "'";
                if (!Functions.Functions.CheckKey(sql))
                {
                    if (txtName.Text == "")
                    {
                        txtName.PlaceholderText = "Phải nhập";
                        txtName.Focus();
                    }
                    if (txtSdt.Text == "") ;
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
                    sql = "INSERT INTO [dbo].[tbl_nhanvien]([MaNV],[TenNV],[Giới tính],[DiaChi],[DienThoai],[NgaySinh],[LoaiLuong],[ChucVu],[Ava]) VALUES (N'" + txtId.Text.Trim() + "',N'" + txtName.Text.Trim() + "',N'" + checkBox() + "',N'" + txtDiaChi.Text + "','" + txtSdt.Text + "','" + dateNgaySinh.Value.Date.ToString("dd/MM/yyyy") + "',N'" + a + "',N'" + b + "',@image)";
                    String sql2 = "INSERT INTO [dbo].[tbl_Account]([MaNV],[Username],[Pass],[ChucVu])VALUES(N'" + txtId.Text.Trim() + "',N'" + txtUsername.Text + "',N'" + pass + "',N'" + b + "')";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.Add("@image", SqlDbType.Image);
                    cmd.Parameters["@image"].Value = Functions.Functions.getByteImage(picAva);
                    Functions.Functions.RunSQL(sql, cmd);
                    Functions.Functions.RunSQL(sql2, cmd);
                    Functions.Functions.Disconnect();
                    MessageBox.Show("Thêm thành công!!!");
                    resetGripView();
                    return;
                } else
                    MessageBox.Show("Id đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            String username = txtId.Text.ToUpper().Trim();
            username = "@" + username;
            txtUsername.Text = username;
        }

        private void addUserready()
        {
            String[] b = new string[2] { "admin", "nv" };
            cobChucVu.Items.AddRange(b);
            cobChucVu.SelectedIndex = 2;
            String[] a = new String[5] { "loai 1", "loai 2", "loai 3", "loai 4", "ql" };
            cobLoaiLuong.Items.AddRange(a);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void dataDSNV1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            XemThongTin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

        private String getSelectedRowId()
        { var row = this.dataDSNV1.CurrentRow;
            String id = string.Format("{0}", row.Cells[1].Value);
            return id;

        }

        public void resetGripView()
        {
            dataDSNV1.Rows.Clear();
            loadDataToGripView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            resetGripView();
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemThongTin();
        }

        private void XemThongTin()
        {
            Functions.Functions.setID(getSelectedRowId());
            FormChiTietUser form = new FormChiTietUser();
            form.ShowDialog();
        }

        private void SuaThongTin()
        {
            Functions.Functions.setID(getSelectedRowId());
            FormEdditUser edditUser = new FormEdditUser();
            edditUser.ShowDialog();
        }

        private void Them()
        {
            if (panel_Adduser.Visible == false)
            {
                panel_Adduser.Visible = true;
                txtDiaChi.Text = "";
                txtId.Text = "";
                txtSdt.Text = "";
                txtName.Text = "";
            }
        }
        private void Xoa()
        {
            DialogResult dialog1 = MessageBox.Show("Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialog1 == DialogResult.OK)
            {
                String sql = "DELETE FROM[dbo].[tbl_nhanvien] WHERE MaNV = @id";
                String sql2 = "DELETE FROM[dbo].[tbl_Account] WHERE MaNV = @id";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@id", getSelectedRowId());
                Functions.Functions.RunSQL(sql2, cmd);
                Functions.Functions.RunSQL(sql, cmd);
                resetGripView();
                Functions.Functions.Disconnect();
            }
            else return;
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them();
        }

        private void sửaNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

        private void xóaNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void tạoMớiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGripView();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void dataDSNV1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedRowId();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            String sreach = textBox1.Text.ToUpper().Trim();
            String sql = "select * from dbo.tbl_nhanvien where MaNV = '"+sreach+"'"; 
            DSNV = Functions.Functions.GetDataToTable(sql);
            dataDSNV1.Rows.Clear();
            if (DSNV != null)
            {
                int i = 1;
                foreach (DataRow row in DSNV.Rows)
                {
                    dataDSNV1.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                    i++;
                }
            }
            
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            picAva.Image = Properties.Resources.d2e922c51bda62ccd55ef2fb872dfa10;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }


        //Functions.Export.export(dataDSNV1);
        //loadDataToGripView();
        // Functions.Functions.ExportPDF(dataDSNV1, "filepdf");

    }

}

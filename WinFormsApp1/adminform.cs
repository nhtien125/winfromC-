using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.Functions;

namespace WinFormsApp1
{
    public partial class adminform : Form
    {
        public static adminform guiAdmin;
        private Form active = null;
        public static String currentID;
        public adminform()
        {            
           InitializeComponent();
           guiAdmin = this;
            checkRoles();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (active != null)
            {
                active.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSub(panelSubCc);
        }

       
        
        public void design2()
        {
            if (panelSubNV.Visible == true)
            {
                panelSubNV.Visible = false;
            }
            if (panelSubLuong.Visible == true)
            { panelSubLuong.Visible = false; }
            if (panelSubCc.Visible == true)
            {
                panelSubCc.Visible = false;
            }
        }

        public void showSub(Panel panel)
        {
            if (panel.Visible == false)
            {
                
                panel.Visible = true;
            }
            else
                { panel.Visible = false; }
        }

        private void btnControlnv_Click(object sender, EventArgs e)
        {
            showSub(panelSubNV);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSub(panelSubLuong);
        }

        public void openForm(Form childForm)
        {
            if (active != null)
            {
                active.Close();
            }
            active = childForm;
            childForm.TopLevel = false;          
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void setWelcome(String text)
        {
            lblWelcome.Text = "" + text;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new FormDSNV1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //active.Dispose();
            openForm(new FormInDSNV());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            Functions.Functions.setID(currentID);
            FormChiTietUser form = new FormChiTietUser();
            form.ShowDialog();
        }

        private void checkRoles()
        {
            String role = Functions.Functions.getRoles();
            if (role == "nv")
            {
                panelSubNV.Visible = false;
                btnControlnv.Enabled = false;
                btnControlnv.Visible = false;
                btnLichSuCC.Visible = false;
                btnBangLuong.Visible = false;
                btnInBangLuong.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panelSubCc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            openForm(new Luongchitiet());
        }

        public static String getCurrentID()
        {
            String a = currentID;
            return a;
        }
        public static void setCurrentID(String id)
        {
            currentID = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Functions.Functions.Disconnect();
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
            this.Dispose();
            active.Dispose();
        }

        private void lblWelcome_Click_1(object sender, EventArgs e)
        {            
        }

        private void lblWelcome_MouseHover(object sender, EventArgs e)
        {
            panelChiTiet.Visible = true;
            panelChiTiet.BringToFront();
        }

        private void lblWelcome_MouseLeave(object sender, EventArgs e)
        {           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Functions.Functions.setID(currentID);
            FormEdditUser form = new FormEdditUser();
            form.UserSetting();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Functions.Functions.setID(currentID);
            FormChiTietUser form = new FormChiTietUser();
            form.ShowDialog();
            
        }

        private void panelChiTiet_MouseLeave(object sender, EventArgs e)
        {
            panelChiTiet.Visible = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            lblXemThongTin.BackColor = SystemColors.ControlLight; 
        }

        private void lblSuaThongTin_MouseHover(object sender, EventArgs e)
        {
            lblSuaThongTin.BackColor = SystemColors.ControlLight;
        }

        private void lblXemThongTin_MouseLeave(object sender, EventArgs e)
        {
            lblXemThongTin.BackColor = SystemColors.ActiveCaption;
        }

        private void lblSuaThongTin_MouseLeave(object sender, EventArgs e)
        {
            lblSuaThongTin.BackColor = SystemColors.ActiveCaption;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
             FormChamCong form = new FormChamCong();
            openForm(form);
        }

        private void adminform_Deactivate(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Dispose();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            openForm(new FormLichSuChamCong());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openForm(new FormXemLuong());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openForm(new Indanhsachluong());
        }

        private void LichSuChamCong(object sender, EventArgs e)
        {
            openForm(new FormLichSuChamCong());
        }
    }
}

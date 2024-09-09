using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp1.Functions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 gui;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            gui = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonMo_Click(object sender, EventArgs e)
        {
            Functions.Functions.Login(tbUname.Text, tbPass.Text);

        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        public void loginStatus_setStatus(String text, bool a)
        {
            loginStatus.Text = text;
            loginStatus.Visible = a;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime.Text = Functions.Functions.dateTime();
        }

        private void btnMo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Focus();
                buttonMo_Click(sender, e);
            }

        }

        private void tbUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus();
                buttonMo_Click(sender, e);
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus();
                buttonMo_Click(sender, e);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions.Functions.Login("@ad001", "12345678");
        }
    }
}
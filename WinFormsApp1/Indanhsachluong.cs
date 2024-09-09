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
    public partial class Indanhsachluong : Form
    {
        public Indanhsachluong()
        {
            InitializeComponent();
        }
        string sql1 = @"Select * from View_2";
      
        String header = "Danh sách lương nhân viên";
        private void button1_Click(object sender, EventArgs e)
        {
            Functions.Functions.createPDF(sql1, header);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Functions.Functions.ExportToExcel(sql1);
        }
    }
}

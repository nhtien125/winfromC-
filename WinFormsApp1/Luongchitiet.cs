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
    public partial class Luongchitiet : Form
    {
        public Luongchitiet()
        {
            InitializeComponent();
        }

        String sqlLoad = null;
        public int month2 = 0;
        DataTable dtgv;
        public void loadDataToGripView()
        {

            String sql = "SELECT * from View_1";
            dtgv = Functions.Functions.GetDataToTable(sql);     


            foreach (DataRow row in dtgv.Rows)
            {

                dtgv1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            dtgv1.Enabled = true;
        }

        private void Luongchitiet_Load(object sender, EventArgs e)
        {
            loadDataToGripView();
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

namespace WinFormsApp1
{
    partial class FormChamCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGioLam = new System.Windows.Forms.TextBox();
            this.lblGioLam = new System.Windows.Forms.Label();
            this.cobLoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 218);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(674, 184);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(337, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 184);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 184);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(200, 184);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(674, 34);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(874, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 218);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 218);
            this.panel2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGioLam);
            this.panel4.Controls.Add(this.lblGioLam);
            this.panel4.Controls.Add(this.cobLoc);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataCC);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(15, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1074, 446);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtGioLam
            // 
            this.txtGioLam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioLam.Enabled = false;
            this.txtGioLam.Location = new System.Drawing.Point(868, 85);
            this.txtGioLam.Name = "txtGioLam";
            this.txtGioLam.Size = new System.Drawing.Size(206, 23);
            this.txtGioLam.TabIndex = 6;
            // 
            // lblGioLam
            // 
            this.lblGioLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGioLam.Location = new System.Drawing.Point(868, 54);
            this.lblGioLam.Name = "lblGioLam";
            this.lblGioLam.Size = new System.Drawing.Size(206, 31);
            this.lblGioLam.TabIndex = 5;
            this.lblGioLam.Text = "Số giờ làm tháng";
            // 
            // cobLoc
            // 
            this.cobLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cobLoc.FormattingEnabled = true;
            this.cobLoc.Items.AddRange(new object[] {
            "Chọn tháng",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cobLoc.Location = new System.Drawing.Point(868, 31);
            this.cobLoc.Name = "cobLoc";
            this.cobLoc.Size = new System.Drawing.Size(206, 23);
            this.cobLoc.TabIndex = 4;
            this.cobLoc.SelectedIndexChanged += new System.EventHandler(this.cobLoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(868, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc theo tháng";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataCC
            // 
            this.dataCC.AllowUserToResizeColumns = false;
            this.dataCC.AllowUserToResizeRows = false;
            this.dataCC.BackgroundColor = System.Drawing.Color.White;
            this.dataCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataCC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCC.Location = new System.Drawing.Point(0, 0);
            this.dataCC.Name = "dataCC";
            this.dataCC.ReadOnly = true;
            this.dataCC.RowHeadersVisible = false;
            this.dataCC.RowHeadersWidth = 51;
            this.dataCC.RowTemplate.Height = 25;
            this.dataCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCC.Size = new System.Drawing.Size(868, 446);
            this.dataCC.TabIndex = 0;
            this.dataCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 13.5F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã Nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thứ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Ngày";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Check In";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Check Out";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Giờ làm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 694);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChamCong";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "FormChamCong";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Panel panel4;
        private DataGridView dataCC;
        private ComboBox cobLoc;
        private Label label1;
        private Panel panel5;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox txtGioLam;
        private Label lblGioLam;
    }
}
namespace WinFormsApp1
{
    partial class FormXemLuong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuongthang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoailuong = new System.Windows.Forms.TextBox();
            this.cbManhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGioLam = new System.Windows.Forms.ComboBox();
            this.cobLoc = new System.Windows.Forms.ComboBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1088, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng lương. Mã NV: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTongtien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLuongthang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtLoailuong);
            this.panel2.Controls.Add(this.cbManhanvien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGioLam);
            this.panel2.Controls.Add(this.cobLoc);
            this.panel2.Controls.Add(this.txtTennhanvien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 324);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tính lương tháng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tổng lương tháng";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(793, 162);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(100, 23);
            this.txtTongtien.TabIndex = 13;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lương / tháng";
            // 
            // txtLuongthang
            // 
            this.txtLuongthang.Location = new System.Drawing.Point(793, 34);
            this.txtLuongthang.Name = "txtLuongthang";
            this.txtLuongthang.Size = new System.Drawing.Size(100, 23);
            this.txtLuongthang.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại lương";
            // 
            // txtLoailuong
            // 
            this.txtLoailuong.Location = new System.Drawing.Point(280, 241);
            this.txtLoailuong.Name = "txtLoailuong";
            this.txtLoailuong.Size = new System.Drawing.Size(120, 23);
            this.txtLoailuong.TabIndex = 9;
            // 
            // cbManhanvien
            // 
            this.cbManhanvien.FormattingEnabled = true;
            this.cbManhanvien.Location = new System.Drawing.Point(277, 32);
            this.cbManhanvien.Name = "cbManhanvien";
            this.cbManhanvien.Size = new System.Drawing.Size(121, 23);
            this.cbManhanvien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng số giờ làm theo tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lọc theo tháng";
            // 
            // txtGioLam
            // 
            this.txtGioLam.FormattingEnabled = true;
            this.txtGioLam.Location = new System.Drawing.Point(279, 189);
            this.txtGioLam.Name = "txtGioLam";
            this.txtGioLam.Size = new System.Drawing.Size(121, 23);
            this.txtGioLam.TabIndex = 5;
            this.txtGioLam.SelectedIndexChanged += new System.EventHandler(this.txtGioLam_SelectedIndexChanged);
            // 
            // cobLoc
            // 
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
            this.cobLoc.Location = new System.Drawing.Point(279, 130);
            this.cobLoc.Name = "cobLoc";
            this.cobLoc.Size = new System.Drawing.Size(121, 23);
            this.cobLoc.TabIndex = 4;
            this.cobLoc.SelectedIndexChanged += new System.EventHandler(this.cobLoc_SelectedIndexChanged);
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(279, 77);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(184, 23);
            this.txtTennhanvien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân viên: ";
            // 
            // FormXemLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormXemLuong";
            this.Text = "FormXemLuong";
            this.Load += new System.EventHandler(this.FormXemLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtTennhanvien;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox txtGioLam;
        private ComboBox cobLoc;
        private ComboBox cbManhanvien;
        private Label label6;
        private TextBox txtLoailuong;
        private Label label7;
        private TextBox txtLuongthang;
        private Label label8;
        private TextBox txtTongtien;
        private Button button1;
    }
}
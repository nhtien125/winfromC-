namespace WinFormsApp1
{
    partial class FormChiTietUser
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLoaiLuong = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.picAvaProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvaProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 33);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources._298889_x_icon;
            this.pictureBox1.Location = new System.Drawing.Point(874, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 37);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(926, 421);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.lblLoaiLuong);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(271, 10);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(645, 401);
            this.panel4.TabIndex = 1;
            // 
            // lblLoaiLuong
            // 
            this.lblLoaiLuong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoaiLuong.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoaiLuong.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLoaiLuong.Location = new System.Drawing.Point(20, 330);
            this.lblLoaiLuong.Name = "lblLoaiLuong";
            this.lblLoaiLuong.Size = new System.Drawing.Size(571, 51);
            this.lblLoaiLuong.TabIndex = 3;
            this.lblLoaiLuong.Text = "Loại Lương: ";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblNgaySinh);
            this.panel6.Controls.Add(this.lblGioiTinh);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(20, 203);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(605, 127);
            this.panel6.TabIndex = 2;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoEllipsis = true;
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNgaySinh.Location = new System.Drawing.Point(351, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(252, 125);
            this.lblNgaySinh.TabIndex = 1;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoEllipsis = true;
            this.lblGioiTinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGioiTinh.Location = new System.Drawing.Point(0, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(201, 125);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới tính: ";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblDiaChi);
            this.panel5.Controls.Add(this.lblSdt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(20, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(605, 123);
            this.panel5.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoEllipsis = true;
            this.lblDiaChi.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDiaChi.Location = new System.Drawing.Point(350, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(253, 121);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ: ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoEllipsis = true;
            this.lblSdt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSdt.Location = new System.Drawing.Point(0, 0);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(290, 121);
            this.lblSdt.TabIndex = 0;
            this.lblSdt.Text = "Số điện thoại:";
            this.lblSdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin người dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblChucVu);
            this.panel3.Controls.Add(this.picAvaProfile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 401);
            this.panel3.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblName.Location = new System.Drawing.Point(0, 221);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 34);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label2";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChucVu.Location = new System.Drawing.Point(0, 255);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(261, 146);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "label1";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picAvaProfile
            // 
            this.picAvaProfile.Image = global::WinFormsApp1.Properties.Resources.d2e922c51bda62ccd55ef2fb872dfa10;
            this.picAvaProfile.Location = new System.Drawing.Point(42, 18);
            this.picAvaProfile.Name = "picAvaProfile";
            this.picAvaProfile.Size = new System.Drawing.Size(177, 177);
            this.picAvaProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvaProfile.TabIndex = 0;
            this.picAvaProfile.TabStop = false;
            this.picAvaProfile.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormChiTietUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormChiTietUser";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 33);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietUser";
            this.Load += new System.EventHandler(this.FormChiTietUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvaProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox picAvaProfile;
        private Label lblChucVu;
        private Label lblName;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Label lblSdt;
        private Label lblDiaChi;
        private Panel panel6;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblLoaiLuong;
    }
}
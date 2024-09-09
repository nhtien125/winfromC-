namespace WinFormsApp1
{
    partial class Luongchitiet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tonggio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lương_Giờ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thangchamcong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namchamcong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtienluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng lương chi tiết ";
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Tonggio,
            this.Lương_Giờ,
            this.Thangchamcong,
            this.Namchamcong,
            this.Thanhtienluong});
            this.dtgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv1.Location = new System.Drawing.Point(3, 19);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowTemplate.Height = 25;
            this.dtgv1.Size = new System.Drawing.Size(844, 420);
            this.dtgv1.TabIndex = 0;
            this.dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "TenNV";
            this.TenNV.Name = "TenNV";
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Tonggio
            // 
            this.Tonggio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tonggio.HeaderText = "Tổng giờ";
            this.Tonggio.Name = "Tonggio";
            // 
            // Lương_Giờ
            // 
            this.Lương_Giờ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lương_Giờ.HeaderText = "Lương/giờ";
            this.Lương_Giờ.Name = "Lương_Giờ";
            // 
            // Thangchamcong
            // 
            this.Thangchamcong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thangchamcong.HeaderText = "Tháng chấm công";
            this.Thangchamcong.Name = "Thangchamcong";
            // 
            // Namchamcong
            // 
            this.Namchamcong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Namchamcong.HeaderText = "Năm chấm công";
            this.Namchamcong.Name = "Namchamcong";
            // 
            // Thanhtienluong
            // 
            this.Thanhtienluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thanhtienluong.HeaderText = "Thành tiền lương";
            this.Thanhtienluong.Name = "Thanhtienluong";
            // 
            // Luongchitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 442);
            this.Controls.Add(this.groupBox1);
            this.Name = "Luongchitiet";
            this.Text = "Luongchitiet";
            this.Load += new System.EventHandler(this.Luongchitiet_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgv1;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Tonggio;
        private DataGridViewTextBoxColumn Lương_Giờ;
        private DataGridViewTextBoxColumn Thangchamcong;
        private DataGridViewTextBoxColumn Namchamcong;
        private DataGridViewTextBoxColumn Thanhtienluong;
    }
}
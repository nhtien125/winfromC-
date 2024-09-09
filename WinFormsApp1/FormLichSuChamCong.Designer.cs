namespace WinFormsApp1
{
    partial class FormLichSuChamCong
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
            System.Windows.Forms.Panel panel15;
            System.Windows.Forms.Panel panel2;
            this.lblToday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataChamCong = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTongMuon = new System.Windows.Forms.Label();
            this.lblTongChuaCC = new System.Windows.Forms.Label();
            this.lblTongCC = new System.Windows.Forms.Label();
            this.lblTongNV = new System.Windows.Forms.Label();
            panel15 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel15.SuspendLayout();
            panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.White;
            panel15.Controls.Add(this.lblToday);
            panel15.Dock = System.Windows.Forms.DockStyle.Left;
            panel15.Location = new System.Drawing.Point(0, 0);
            panel15.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            panel15.Name = "panel15";
            panel15.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            panel15.Size = new System.Drawing.Size(197, 94);
            panel15.TabIndex = 10;
            // 
            // lblToday
            // 
            this.lblToday.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToday.Location = new System.Drawing.Point(4, 6);
            this.lblToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(189, 82);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Lấy danh sách ngày hôm nay";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToday.Click += new System.EventHandler(this.lblToday_Click);
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(this.label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(197, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            panel2.Size = new System.Drawing.Size(197, 94);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh công cụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(panel2);
            this.panel1.Controls.Add(panel15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 94);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.pictureBox3);
            this.panel16.Controls.Add(this.textBox1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(608, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(480, 94);
            this.panel16.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormsApp1.Properties.Resources._2203511_find_glass_look_magnify_search_icon;
            this.pictureBox3.Location = new System.Drawing.Point(325, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(0, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Tìm kiếm nhân viên theo mã";
            this.textBox1.Size = new System.Drawing.Size(319, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataChamCong);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1088, 561);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataChamCong
            // 
            this.dataChamCong.AllowUserToAddRows = false;
            this.dataChamCong.AllowUserToDeleteRows = false;
            this.dataChamCong.BackgroundColor = System.Drawing.Color.White;
            this.dataChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.ma,
            this.WeekDay,
            this.date1,
            this.date2,
            this.Column2,
            this.Column1});
            this.dataChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataChamCong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataChamCong.Location = new System.Drawing.Point(10, 10);
            this.dataChamCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataChamCong.Name = "dataChamCong";
            this.dataChamCong.ReadOnly = true;
            this.dataChamCong.RowHeadersVisible = false;
            this.dataChamCong.RowHeadersWidth = 51;
            this.dataChamCong.RowTemplate.Height = 25;
            this.dataChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChamCong.Size = new System.Drawing.Size(1068, 473);
            this.dataChamCong.TabIndex = 2;
            this.dataChamCong.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataChamCong_RowsAdded);
            this.dataChamCong.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataChamCong_RowsRemoved);
            // 
            // Stt
            // 
            this.Stt.FillWeight = 60F;
            this.Stt.HeaderText = "Stt";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            this.Stt.ReadOnly = true;
            this.Stt.Width = 60;
            // 
            // ma
            // 
            this.ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma.FillWeight = 8.8F;
            this.ma.HeaderText = "Mã nhân viên";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // WeekDay
            // 
            this.WeekDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WeekDay.FillWeight = 14.50143F;
            this.WeekDay.HeaderText = "Tên nhân viên";
            this.WeekDay.MinimumWidth = 6;
            this.WeekDay.Name = "WeekDay";
            this.WeekDay.ReadOnly = true;
            // 
            // date1
            // 
            this.date1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date1.FillWeight = 10F;
            this.date1.HeaderText = "Ngày chấm";
            this.date1.MinimumWidth = 6;
            this.date1.Name = "date1";
            this.date1.ReadOnly = true;
            // 
            // date2
            // 
            this.date2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date2.FillWeight = 8.50143F;
            this.date2.HeaderText = "Check In";
            this.date2.MinimumWidth = 6;
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 13F;
            this.Column2.HeaderText = "Check Out";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 13.50143F;
            this.Column1.HeaderText = "Ghi chú";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTongMuon);
            this.panel5.Controls.Add(this.lblTongChuaCC);
            this.panel5.Controls.Add(this.lblTongCC);
            this.panel5.Controls.Add(this.lblTongNV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1068, 68);
            this.panel5.TabIndex = 0;
            // 
            // lblTongMuon
            // 
            this.lblTongMuon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTongMuon.Location = new System.Drawing.Point(801, 0);
            this.lblTongMuon.Name = "lblTongMuon";
            this.lblTongMuon.Size = new System.Drawing.Size(267, 68);
            this.lblTongMuon.TabIndex = 3;
            this.lblTongMuon.Text = "Nhân viên chưa check out: ";
            this.lblTongMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongChuaCC
            // 
            this.lblTongChuaCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTongChuaCC.Location = new System.Drawing.Point(534, 0);
            this.lblTongChuaCC.Name = "lblTongChuaCC";
            this.lblTongChuaCC.Size = new System.Drawing.Size(267, 68);
            this.lblTongChuaCC.TabIndex = 2;
            this.lblTongChuaCC.Text = "Nhân viên chưa chấm công: ";
            this.lblTongChuaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongCC
            // 
            this.lblTongCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTongCC.Location = new System.Drawing.Point(267, 0);
            this.lblTongCC.Name = "lblTongCC";
            this.lblTongCC.Size = new System.Drawing.Size(267, 68);
            this.lblTongCC.TabIndex = 1;
            this.lblTongCC.Text = "Nhân viên đã chấm công: ";
            this.lblTongCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTongCC.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTongNV
            // 
            this.lblTongNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTongNV.Location = new System.Drawing.Point(0, 0);
            this.lblTongNV.Name = "lblTongNV";
            this.lblTongNV.Size = new System.Drawing.Size(267, 68);
            this.lblTongNV.TabIndex = 0;
            this.lblTongNV.Text = "Tổng nhân viên: ";
            this.lblTongNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLichSuChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 655);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLichSuChamCong";
            this.Text = "FormLichSuChamCong";
            this.Load += new System.EventHandler(this.FormLichSuChamCong_Load);
            panel15.ResumeLayout(false);
            panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblToday;
        private Panel panel4;
        private DataGridView dataChamCong;
        private DataGridViewTextBoxColumn Stt;
        private DataGridViewTextBoxColumn ma;
        private DataGridViewTextBoxColumn WeekDay;
        private DataGridViewTextBoxColumn date1;
        private DataGridViewTextBoxColumn date2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Panel panel5;
        private Label lblTongMuon;
        private Label lblTongChuaCC;
        private Label lblTongCC;
        private Label lblTongNV;
        private Panel panel16;
        private PictureBox pictureBox3;
        private TextBox textBox1;
    }
}
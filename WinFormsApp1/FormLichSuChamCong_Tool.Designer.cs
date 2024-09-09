namespace WinFormsApp1
{
    partial class FormLichSuChamCong_Tool
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtControl = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 619);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaNV);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 248);
            this.panel4.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaNV.Location = new System.Drawing.Point(0, 120);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PlaceholderText = "Nhập mã nhân viên";
            this.txtMaNV.Size = new System.Drawing.Size(392, 29);
            this.txtMaNV.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(0, 80);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(392, 40);
            this.button7.TabIndex = 7;
            this.button7.Text = "In tất cả Danh sách chấm công của nhân viên";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(0, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(392, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "In tất cả Danh sách chấm công";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "In Danh sách chấm công vào ngày";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 214);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(0, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(392, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hiển thị danh sách tất cả";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(0, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(392, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lấy danh sách vào ngày";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lọc nhân viên chưa check out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lọc nhân viên chưa chấm công";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lọc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtControl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 65);
            this.panel2.TabIndex = 0;
            // 
            // dtControl
            // 
            this.dtControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtControl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtControl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtControl.Location = new System.Drawing.Point(0, 18);
            this.dtControl.Name = "dtControl";
            this.dtControl.Size = new System.Drawing.Size(392, 30);
            this.dtControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngày ";
            // 
            // FormLichSuChamCong_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 659);
            this.Controls.Add(this.panel1);
            this.Name = "FormLichSuChamCong_Tool";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLichSuChamCong_Tool";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public DateTimePicker dtControl;
        private Label label1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Button button4;
        private Panel panel4;
        private TextBox txtMaNV;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}
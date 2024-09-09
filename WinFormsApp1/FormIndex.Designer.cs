namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMo = new System.Windows.Forms.Button();
            this.bntDong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginStatus = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMo
            // 
            this.btnMo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMo.Location = new System.Drawing.Point(128, 508);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(151, 76);
            this.btnMo.TabIndex = 1;
            this.btnMo.Text = "Đăng nhập";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.buttonMo_Click);
            this.btnMo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnMo_KeyDown);
            // 
            // bntDong
            // 
            this.bntDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDong.Location = new System.Drawing.Point(411, 508);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(151, 70);
            this.bntDong.TabIndex = 2;
            this.bntDong.Text = "Thoát";
            this.bntDong.UseVisualStyleBackColor = true;
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.Logo_Học_Viện_Nông_Nghiệp_Việt_Nam___VNUA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chương trình quản lý nhân sự";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginStatus);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbUname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // loginStatus
            // 
            this.loginStatus.AutoSize = true;
            this.loginStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginStatus.Location = new System.Drawing.Point(311, 171);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(0, 15);
            this.loginStatus.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.Location = new System.Drawing.Point(258, 144);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(329, 23);
            this.tbPass.TabIndex = 3;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // tbUname
            // 
            this.tbUname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUname.Location = new System.Drawing.Point(258, 100);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(329, 23);
            this.tbUname.TabIndex = 2;
            this.tbUname.TextChanged += new System.EventHandler(this.tbUname_TextChanged_1);
            this.tbUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUname_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(96, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateTime
            // 
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(63, 17);
            this.dateTime.Text = "DateTime: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "adminmode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(699, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.btnMo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnMo;
        private Button bntDong;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox tbPass;
        private TextBox tbUname;
        public Label loginStatus;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel dateTime;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}
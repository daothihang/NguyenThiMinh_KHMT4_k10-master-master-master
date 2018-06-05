namespace NguyenThiMinh_KHMT4_k10
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.btndnhap = new System.Windows.Forms.Button();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboloaitk = new System.Windows.Forms.ComboBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndnhap
            // 
            this.btndnhap.BackColor = System.Drawing.Color.Blue;
            this.btndnhap.ForeColor = System.Drawing.Color.White;
            this.btndnhap.Location = new System.Drawing.Point(80, 140);
            this.btndnhap.Name = "btndnhap";
            this.btndnhap.Size = new System.Drawing.Size(90, 28);
            this.btndnhap.TabIndex = 1;
            this.btndnhap.Text = "Đăng nhập";
            this.btndnhap.UseVisualStyleBackColor = false;
            this.btndnhap.Click += new System.EventHandler(this.btndnhap_Click);
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(137, 19);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(100, 21);
            this.txttendn.TabIndex = 2;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(137, 61);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(100, 21);
            this.txtmk.TabIndex = 3;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboloaitk);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttendn);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.btndnhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(229, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // cboloaitk
            // 
            this.cboloaitk.FormattingEnabled = true;
            this.cboloaitk.Location = new System.Drawing.Point(137, 98);
            this.cboloaitk.Name = "cboloaitk";
            this.cboloaitk.Size = new System.Drawing.Size(100, 23);
            this.cboloaitk.TabIndex = 9;
            this.cboloaitk.SelectedIndexChanged += new System.EventHandler(this.cboloaitk_SelectedIndexChanged);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Blue;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(193, 140);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(93, 28);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "PassWord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-3, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(549, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "ĐĂNG NHẬP";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 186);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dangnhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndnhap;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboloaitk;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}


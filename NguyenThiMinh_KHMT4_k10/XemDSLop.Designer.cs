namespace NguyenThiMinh_KHMT4_k10
{
    partial class XemDSLop
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
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnTimMa = new System.Windows.Forms.Button();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Location = new System.Drawing.Point(12, 111);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.Size = new System.Drawing.Size(351, 150);
            this.dgvDSLop.TabIndex = 0;
            this.dgvDSLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(12, 72);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(146, 20);
            this.txtMaLop.TabIndex = 0;
            // 
            // btnTimMa
            // 
            this.btnTimMa.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimMa.Location = new System.Drawing.Point(68, 22);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(90, 29);
            this.btnTimMa.TabIndex = 3;
            this.btnTimMa.Text = "Tìm theo mã";
            this.btnTimMa.UseVisualStyleBackColor = false;
            this.btnTimMa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimTen
            // 
            this.btnTimTen.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimTen.Location = new System.Drawing.Point(288, 22);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(75, 29);
            this.btnTimTen.TabIndex = 4;
            this.btnTimTen.Text = "Tìm theo tên";
            this.btnTimTen.UseVisualStyleBackColor = false;
            this.btnTimTen.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên lớp";
            // 
            // cbTen
            // 
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(199, 72);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(164, 21);
            this.cbTen.TabIndex = 1;
            // 
            // XemDSLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(376, 274);
            this.Controls.Add(this.cbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimTen);
            this.Controls.Add(this.btnTimMa);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSLop);
            this.Name = "XemDSLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDSLop";
            this.Load += new System.EventHandler(this.XemDSLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTen;
    }
}
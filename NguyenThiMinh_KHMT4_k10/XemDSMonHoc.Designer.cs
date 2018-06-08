namespace NguyenThiMinh_KHMT4_k10
{
    partial class XemDSMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.btnTimMa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimTen = new System.Windows.Forms.Button();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.dgvDSMonHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(16, 64);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(168, 20);
            this.txtMaMon.TabIndex = 0;
            // 
            // btnTimMa
            // 
            this.btnTimMa.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimMa.Location = new System.Drawing.Point(85, 17);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(99, 26);
            this.btnTimMa.TabIndex = 2;
            this.btnTimMa.Text = "Tìm theo mã";
            this.btnTimMa.UseVisualStyleBackColor = false;
            this.btnTimMa.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên môn";
            // 
            // btnTimTen
            // 
            this.btnTimTen.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimTen.Location = new System.Drawing.Point(316, 18);
            this.btnTimTen.Name = "btnTimTen";
            this.btnTimTen.Size = new System.Drawing.Size(97, 25);
            this.btnTimTen.TabIndex = 4;
            this.btnTimTen.Text = "Tìm theo tên";
            this.btnTimTen.UseVisualStyleBackColor = false;
            this.btnTimTen.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbTenMon
            // 
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Location = new System.Drawing.Point(242, 64);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(171, 21);
            this.cbTenMon.TabIndex = 1;
            // 
            // dgvDSMonHoc
            // 
            this.dgvDSMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHoc.Location = new System.Drawing.Point(16, 123);
            this.dgvDSMonHoc.Name = "dgvDSMonHoc";
            this.dgvDSMonHoc.Size = new System.Drawing.Size(397, 150);
            this.dgvDSMonHoc.TabIndex = 6;
            this.dgvDSMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // XemDSMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(429, 285);
            this.Controls.Add(this.dgvDSMonHoc);
            this.Controls.Add(this.cbTenMon);
            this.Controls.Add(this.btnTimTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimMa);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label1);
            this.Name = "XemDSMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDSMonHoc";
            this.Load += new System.EventHandler(this.XemDSMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimTen;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.DataGridView dgvDSMonHoc;
    }
}
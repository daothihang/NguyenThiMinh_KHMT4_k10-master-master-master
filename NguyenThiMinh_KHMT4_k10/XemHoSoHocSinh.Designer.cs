namespace NguyenThiMinh_KHMT4_k10
{
    partial class XemHoSoHocSinh
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
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHT = new System.Windows.Forms.DataGridView();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(417, 37);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvHT
            // 
            this.dgvHT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHT.Location = new System.Drawing.Point(22, 99);
            this.dgvHT.Name = "dgvHT";
            this.dgvHT.Size = new System.Drawing.Size(545, 117);
            this.dgvHT.TabIndex = 3;
            // 
            // txtMaHS
            // 
            this.txtMaHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtMaHS.Location = new System.Drawing.Point(204, 35);
            this.txtMaHS.Multiline = true;
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(142, 30);
            this.txtMaHS.TabIndex = 4;
            // 
            // XemHoSoHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 231);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.dgvHT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.Name = "XemHoSoHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemHoSoHocSinh";
            this.Load += new System.EventHandler(this.XemHoSoHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHT;
        private System.Windows.Forms.TextBox txtMaHS;
    }
}
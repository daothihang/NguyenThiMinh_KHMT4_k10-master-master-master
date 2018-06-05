namespace NguyenThiMinh_KHMT4_k10
{
    partial class XemCanBoGV
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
            this.dgvHT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCBGV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(436, 38);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvHT
            // 
            this.dgvHT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHT.Location = new System.Drawing.Point(25, 93);
            this.dgvHT.Name = "dgvHT";
            this.dgvHT.Size = new System.Drawing.Size(576, 100);
            this.dgvHT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã cán bộ giáo viên";
            // 
            // txtMaCBGV
            // 
            this.txtMaCBGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtMaCBGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCBGV.Location = new System.Drawing.Point(234, 38);
            this.txtMaCBGV.Multiline = true;
            this.txtMaCBGV.Name = "txtMaCBGV";
            this.txtMaCBGV.Size = new System.Drawing.Size(144, 30);
            this.txtMaCBGV.TabIndex = 4;
            // 
            // XemCanBoGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 225);
            this.Controls.Add(this.txtMaCBGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHT);
            this.Controls.Add(this.btnTim);
            this.Name = "XemCanBoGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemCanBoGV";
            this.Load += new System.EventHandler(this.XemCanBoGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCBGV;
    }
}
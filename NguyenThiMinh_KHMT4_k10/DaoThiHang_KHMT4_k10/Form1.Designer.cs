namespace DaoThiHang_KHMT4_k10
{
    partial class Form1
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
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbMonHoc = new System.Windows.Forms.TextBox();
            this.txtbTenMon = new System.Windows.Forms.TextBox();
            this.txtbSoTiet = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbMaMonHoc = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(30, 206);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(391, 150);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tiết";
            // 
            // txtbMonHoc
            // 
            this.txtbMonHoc.Location = new System.Drawing.Point(131, 27);
            this.txtbMonHoc.Name = "txtbMonHoc";
            this.txtbMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txtbMonHoc.TabIndex = 4;
            // 
            // txtbTenMon
            // 
            this.txtbTenMon.Location = new System.Drawing.Point(131, 67);
            this.txtbTenMon.Name = "txtbTenMon";
            this.txtbTenMon.Size = new System.Drawing.Size(100, 20);
            this.txtbTenMon.TabIndex = 5;
            // 
            // txtbSoTiet
            // 
            this.txtbSoTiet.Location = new System.Drawing.Point(131, 108);
            this.txtbSoTiet.Name = "txtbSoTiet";
            this.txtbSoTiet.Size = new System.Drawing.Size(100, 20);
            this.txtbSoTiet.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(328, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(328, 63);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(328, 103);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã môn học";
            // 
            // txtbMaMonHoc
            // 
            this.txtbMaMonHoc.Location = new System.Drawing.Point(131, 145);
            this.txtbMaMonHoc.Name = "txtbMaMonHoc";
            this.txtbMaMonHoc.Size = new System.Drawing.Size(100, 20);
            this.txtbMaMonHoc.TabIndex = 11;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(328, 143);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 12;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(328, 177);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 368);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtbMaMonHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtbSoTiet);
            this.Controls.Add(this.txtbTenMon);
            this.Controls.Add(this.txtbMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMonHoc);
            this.Name = "Form1";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbMonHoc;
        private System.Windows.Forms.TextBox txtbTenMon;
        private System.Windows.Forms.TextBox txtbSoTiet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbMaMonHoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHuy;
    }
}


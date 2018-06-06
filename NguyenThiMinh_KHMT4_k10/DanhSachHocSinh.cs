using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class DanhSachHocSinh : Form
    {
        public DanhSachHocSinh()
        {
            InitializeComponent();
        }
        LopBUL lopBUL = new LopBUL();
        private void DanhSachHocSinh_Load(object sender, EventArgs e)
        {
            cbTenLop.DataSource = lopBUL.LayDsLop();
            cbTenLop.DisplayMember = "TenLop";
            cbTenLop.ValueMember = "TenLop";
           

        }

        private void dgvDanhSachHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbTenLop.Text == (string)cbTenLop.SelectedValue)
            {

                LopBUL lp = new LopBUL();
                string TenLop = cbTenLop.Text;
                DataTable dt = lp.DanhSachHocSinh(TenLop);
                dgvDanhSachHocSinh.DataSource = dt;
                dgvDanhSachHocSinh.Columns[1].HeaderText = "TenLop";
                dgvDanhSachHocSinh.Columns[1].Width = 100;
                dgvDanhSachHocSinh.Columns[2].HeaderText = "MaHocSinh";
                dgvDanhSachHocSinh.Columns[2].Width = 100;
                dgvDanhSachHocSinh.Columns[3].HeaderText = "HoTen";
                dgvDanhSachHocSinh.Columns[3].Width = 100;
                dgvDanhSachHocSinh.Columns[4].HeaderText = "GioiTinh";
                dgvDanhSachHocSinh.Columns[4].Width = 100;
                dgvDanhSachHocSinh.Columns[5].HeaderText = "DiaChi";
                dgvDanhSachHocSinh.Columns[5].Width = 100;
                dgvDanhSachHocSinh.Columns[6].HeaderText = "HoTenBoMe";
                dgvDanhSachHocSinh.Columns[6].Width = 100;
                dgvDanhSachHocSinh.Columns[7].HeaderText = "SoDienThoai";
                dgvDanhSachHocSinh.Columns[7].Width = 100;
                for(int i = 0; i < dgvDanhSachHocSinh.Rows.Count-1; i++){
                    dgvDanhSachHocSinh.Rows[i].Cells[0].Value = i +1;
                }



            }
      
        }
        private void btnPrinter_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
           
        }
      
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvDanhSachHocSinh.Width,this.dgvDanhSachHocSinh.Height);
            dgvDanhSachHocSinh.DrawToBitmap(bmp, new Rectangle(0, 0, dgvDanhSachHocSinh.Width, dgvDanhSachHocSinh.Height));
            e.Graphics.DrawImage(bmp,50,200);
            e.Graphics.DrawString("Danh sách học sinh", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(230, 100));
            
        }
    }
}

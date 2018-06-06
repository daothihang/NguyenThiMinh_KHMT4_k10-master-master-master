using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BUL;
using DTO;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class DanhSachGiaoVien  : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();
        }
        LopBUL lop = new LopBUL();
        PhanCongGiangDayBUL pcgd = new PhanCongGiangDayBUL();
        private void _1_Load(object sender, EventArgs e)
        {
            cboTenLop.DataSource = lop.LayDsLop();
            cboTenLop.DisplayMember = "TenLop";
            cboTenLop.ValueMember = "TenLop";
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (cboTenLop.Text == (string)cboTenLop.SelectedValue)
            {
                PhanCongGiangDayBUL phanCongGiangDayBUL = new PhanCongGiangDayBUL();
                string TenLop = cboTenLop.Text;
                DataTable dt = phanCongGiangDayBUL.DSPhanCongGiangDay(TenLop);
                dgvHT.DataSource = dt;
             
                dgvHT.Columns[1].HeaderText = "MaGiaoVien";
                dgvHT.Columns[1].Width = 100;
                dgvHT.Columns[2].HeaderText = "HoTen";
                dgvHT.Columns[2].Width = 100;
                dgvHT.Columns[3].HeaderText = "TenMon";
                dgvHT.Columns[3].Width = 100;
                dgvHT.Columns[4].HeaderText = "NgayphanCong";
                dgvHT.Columns[4].Width = 100;
                dgvHT.Columns[5].HeaderText = "SoDienThoai";
                dgvHT.Columns[5].Width = 100;
                for (int i = 0; i < dgvHT.Rows.Count - 1; i++)
                {
                    dgvHT.Rows[i].Cells[0].Value = i + 1;
                }


            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvHT.Width, this.dgvHT.Height);
            dgvHT.DrawToBitmap(bmp, new Rectangle(0, 0, dgvHT.Width, dgvHT.Height));
            e.Graphics.DrawImage(bmp, 10, 200);
            e.Graphics.DrawString("Danh sách học sinh", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(230, 100));

        }
    }
}


      


    


      




 
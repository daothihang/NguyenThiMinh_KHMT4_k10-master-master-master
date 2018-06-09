using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
         
            lbtitle.Location = new Point(lbtitle.Location.X -i, lbtitle.Location.Y);
            if (lbtitle.Location.X <= 0 -lbtitle.Width|| lbtitle.Location.X > this.Width)
            {
                lbtitle.Location = new Point(lbtitle.Location.X +789+lbtitle.Width, lbtitle.Location.Y);
            }
           

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {

            PhanCongGiangDay phanCong = new PhanCongGiangDay();
            phanCong.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            HoSoHocSinh hoSoHocSinh = new HoSoHocSinh();
            hoSoHocSinh.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc quanLyMonHoc = new QuanLyMonHoc();
            quanLyMonHoc.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            CanBoGiaoVien canBoGiaoVien = new CanBoGiaoVien();
            canBoGiaoVien.Show();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            DanhSachHocSinh danhSachHocSinh = new DanhSachHocSinh();
            danhSachHocSinh.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVien danhSachGiaoVien = new DanhSachGiaoVien();
            danhSachGiaoVien.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doi_MK doimk = new Doi_MK();
            doimk.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoSoHocSinh hs = new XemHoSoHocSinh();
            hs.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemCanBoGV cbgv = new XemCanBoGV();
            cbgv.Show();
        }

        private void xemPhânCôngGiảngDậyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemPhanCong xem = new XemPhanCong();
            xem.Show();
        }
    }
}

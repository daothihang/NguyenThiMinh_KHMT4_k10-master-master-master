﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace NguyenThiMinh_KHMT4_k10
{
    public partial class PhanCongGiangDay : Form
    {
        public PhanCongGiangDay()
        {
            InitializeComponent();
        }

        PhanCongGiangDayBUL myPhanCong = new PhanCongGiangDayBUL();
        LopBUL mylop = new LopBUL();
        CanBoGiaoVienBUL mycbgv = new CanBoGiaoVienBUL();
        MonHocBUL mymon = new MonHocBUL();

        private void PhanCongGiangDay_Load(object sender, EventArgs e)
        {
            hienthi();
            string.Format("{0:dd/MM/yyyy}", datephancong.Value);
           

        }

       
        public void hienthi()
        {
            dgv.DataSource = myPhanCong.LayDanhSachPhanCongGiangDay();
            cbgv.DataSource = mycbgv.LayDsCanBo();
            cbgv.DisplayMember = "HoTen";
            cbgv.SelectedIndex = -1;
            cbgv.ValueMember = "MaCanBoGiaoVien";


            cblop.DataSource = mylop.LayDsLop();
            cblop.DisplayMember = "TenLop";
            cblop.SelectedIndex = -1;
            cblop.ValueMember = "MaLop";

            cbmon.DataSource = mymon.LayDanhSachMonHoc();
            cbmon.DisplayMember = "TenMon";
            cbmon.SelectedIndex=-1;
            cbmon.ValueMember = "MaMon";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin ad = new FormAdmin();
            ad.Show();
        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            
            if (cblop.SelectedIndex != -1 && cbgv.SelectedIndex != -1 && cbmon.SelectedIndex != -1)
            {
                int dem = 0;
                int dk = 0;
                string lop = cblop.SelectedValue.ToString();
                string mon = cbmon.SelectedValue.ToString();
                string macb = cbgv.SelectedValue.ToString();
                string ngaypc = string.Format("{0:dd/MM/yyyy}", datephancong.Value).ToString();
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string lopm = dgv.Rows[i].Cells["MaLop"].Value.ToString();
                    string monm = dgv.Rows[i].Cells["MaMon"].Value.ToString();
                    string macbm = dgv.Rows[i].Cells["MaCanBoGiaoVien"].Value.ToString();
                    string ngaypcm = dgv.Rows[i].Cells["NgayPhanCong"].Value.ToString();
                    if (ngaypc == ngaypcm)
                    {
                        dem++;
                    }
                    if (mon == monm && lop == lopm)
                    {
                        dk++;
                    }
                  
                    //else if (lop == lopm && mon == monm && macb == macbm && ngaypc == ngaypcm)
                    //{
                    //    dk++;
                    //}
                    //else if(macb==macbm && mon !=monm)
                    //{
                    //    dkgv++;
                    //}
                    else
                    {

                    }
                  
                }
                
                    try
                    {
                    if (dem == 0 )
                    {
                        myPhanCong.phanCong((String)cblop.SelectedValue, (String)cbmon.SelectedValue, (String)cbgv.SelectedValue, ngaypc);
                        MessageBox.Show("Phân công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthi();
                    }
                    else if (dem != 0)
                    {
                        MessageBox.Show("Phân Công không thành công do " + ngaypc.ToString() + " lớp " + cblop.Text.ToString() + " đã được phân công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else if (dk != 0)
                    //{
                    //    MessageBox.Show("Phân Công không thành công do môn " + cbmon.Text.ToString() + " lớp " + cblop.Text.ToString() + " đã được phân công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                    catch (Exception)
                    {
                        
                      
                        MessageBox.Show("Phân công không thành công, lỗi do trùng dữ liệu hoặc do lịch giảng dạy này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                }
                
     
                

              
             
            }
            else
            {
                MessageBox.Show("Phân công không thành công, thao tác không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if (cblop.SelectedIndex != -1)
            {
                DataTable dt = myPhanCong.XemDsPhanCongTheoLop(cblop.Text);
                dgv.DataSource = dt;
            }
            else if (cbmon.SelectedIndex != -1)
            {

                DataTable dt1 = myPhanCong.XemDsPhanCongTheoMon(cbmon.Text);
                dgv.DataSource = dt1;
            }
            else if (cbgv.SelectedIndex != -1)
            {
                DataTable dt2 = myPhanCong.XemDsPhanCongTheoGv(cbgv.Text);
                dgv.DataSource = dt2;
            }
            else if (cblop.SelectedIndex == -1 && cbmon.SelectedIndex == -1 && cbgv.SelectedIndex == -1)
            {
                MessageBox.Show("Thao tác không hợp lệ! Bạn cần chọn Tên môn học hoặc Tên lớp hoặc Tên GV. Thank you!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cblop.SelectedIndex != -1 && cbgv.SelectedIndex != -1 && cbmon.SelectedIndex != -1)
            {
                PhanCongGiangDayDTO dto = new PhanCongGiangDayDTO((String)cblop.SelectedValue, (String)cbmon.SelectedValue, (String)cbgv.SelectedValue, datephancong.Text);
                myPhanCong.sua(dto);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
            }
            else
            {
                MessageBox.Show("Thao tác không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doi_MK doimk = new Doi_MK();
            doimk.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            HeThong ht = new HeThong();
            ht.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoSoHocSinh hs = new XemHoSoHocSinh();
            hs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbgv.SelectedIndex = -1;
            cbmon.SelectedIndex = -1;
            cblop.SelectedIndex = -1;
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

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            DanhSachGiaoVien danhSachGiaoVien = new DanhSachGiaoVien();
            danhSachGiaoVien.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemCanBoGV cbgv = new XemCanBoGV();
            cbgv.Show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
             PhanCongGiangDayDTO dto = new PhanCongGiangDayDTO((String)cblop.SelectedValue, (String)cbmon.SelectedValue, (String)cbgv.SelectedValue, datephancong.Text);
             myPhanCong.xoaPC(dto);
             hienthi();
        }

        private void xemPhânCôngGiảngDậyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemPhanCong xem = new XemPhanCong();
            xem.Show();
        }

        private void datephancong_ValueChanged(object sender, EventArgs e)
        {
            string xau = string.Format("{0:dd/MM/yyyy}", datephancong.Value);
        }
    }
}

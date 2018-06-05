using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
namespace NguyenThiMinh_KHMT4_k10
{
    public partial class CanBoGiaoVien : Form
    {
        public CanBoGiaoVien()
        {
            InitializeComponent();
        }

        CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
        private void CanBoGiaoVien_Load(object sender, EventArgs e)
        {
            cboLoaiTK.DataSource = myCB.LayLoaiTK();
            cboLoaiTK.DisplayMember = "LoaiTaiKhoan";
            cboLoaiTK.ValueMember = "LoaiTaiKhoan";
            dgvCBGV.DataSource = myCB.LayDsCanBo();
        }

     
        private void ClearCanBoGiaoVien()
        {
            txtMCBGV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXem.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnXem.Enabled = true;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXem.Enabled = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            XemCanBoGV xem = new XemCanBoGV();
            xem.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                try
                {
                    CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
                    string MaCanBoGiaoVien = txtMCBGV.Text;
                    string HoTen = txtHoTen.Text;
                    string DiaChi = txtDiaChi.Text;
                    string SoDienThoai = txtSDT.Text;
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    string LoaiTaiKhoan = (string)cboLoaiTK.SelectedValue;
                    myCB.Them(MaCanBoGiaoVien, HoTen, DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan);
                    dgvCBGV.DataSource = myCB.LayDsCanBo();
                    btnThem.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm mới không hợp lệ!!!");
                }
            }
            if(btnSua.Enabled==false)
            {
                try
                {
                    CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
                    string MaCanBoGiaoVien = txtMCBGV.Text;
                    string HoTen = txtHoTen.Text;
                    string DiaChi = txtDiaChi.Text;
                    string SoDienThoai = txtSDT.Text;
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    string LoaiTaiKhoan = (string)cboLoaiTK.SelectedValue;
                    myCB.Sua(MaCanBoGiaoVien, HoTen, DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan);
                    dgvCBGV.DataSource = myCB.LayDsCanBo();
                    btnSua.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin  không hợp lệ!!!");
                }
            }
            if(btnXoa.Enabled==false)
            {
                try
                {
                    CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
                    string MaCanBoGiaoVien = txtMCBGV.Text;
                    myCB.Xoa(MaCanBoGiaoVien);

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thông tin  không hợp lệ!!!");
                }
                DialogResult dlr = MessageBox.Show("Thông báo xác nhận xóa",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                {

                }
                if (dlr == DialogResult.Yes)
                {

                    dgvCBGV.DataSource = myCB.LayDsCanBo();
                    ClearCanBoGiaoVien();
                    btnXoa.Enabled = true;
                }
            }
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

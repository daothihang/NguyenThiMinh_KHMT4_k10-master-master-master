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
    public partial class HoSoHocSinh : Form
    {
        public HoSoHocSinh()
        {
            InitializeComponent();
        }
        LopBUL lop = new LopBUL();
        HoSoHocSinhBUL myHSHS = new HoSoHocSinhBUL();
        private void HoSoHocSinh_Load(object sender, EventArgs e)
        {

            cboMaLop.DataSource = lop.LayDsLop();
            cboMaLop.DisplayMember = "Tenlop";
            cboMaLop.ValueMember = "MaLop";
            cboGT.DataSource = myHSHS.LayGT();
            cboGT.DisplayMember = "GioiTinh";
            cboGT.ValueMember = "GioiTinh";
            dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
        }

    

        private void cboGT_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearHoSoHocSinh()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
           
            txtĐiaChi.Clear();
            txtDiemVT.Clear();
            txtTenBM.Clear();
            txtSDT.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            XemHoSoHocSinh hshs = new XemHoSoHocSinh();
            hshs.Show();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            XemHoSoHocSinh xemHoSoHocSinh = new XemHoSoHocSinh();
            xemHoSoHocSinh.Show();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            btnXem.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                try
                {
                    HoSoHocSinhBUL hs = new HoSoHocSinhBUL();
                    string MaHocSinh = txtMaHS.Text;
                    string HoTen = txtHoTen.Text;
                    string NgaySinh = dateTimePicker1.Value.ToString();
                    string GioiTinh = (string)cboGT.SelectedValue;
                    string DiaChi = txtĐiaChi.Text;
                    float DiemVaoTruong = float.Parse(txtDiemVT.Text);
                    string HoTenBoMe = txtTenBM.Text;
                    string SoDienThoai = txtSDT.Text;
                    string MaLop = (string)cboMaLop.SelectedValue;
                    hs.Them(MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, DiemVaoTruong,
                        HoTenBoMe, SoDienThoai, MaLop);
                    dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
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
                    HoSoHocSinhBUL hs = new HoSoHocSinhBUL();
                    string MaHocSinh = txtMaHS.Text;
                    string HoTen = txtHoTen.Text;
                    string NgaySinh = dateTimePicker1.Value.ToString();
                    string GioiTinh = (string)cboGT.SelectedValue;
                    string DiaChi = txtĐiaChi.Text;
                    float DiemVaoTruong = float.Parse(txtDiemVT.Text);
                    string HoTenBoMe = txtTenBM.Text;
                    string SoDienThoai = txtSDT.Text;
                    string MaLop = (string)cboMaLop.SelectedValue;
                    hs.Sua(MaHocSinh, HoTen, NgaySinh, GioiTinh, DiaChi, DiemVaoTruong,
                        HoTenBoMe, SoDienThoai, MaLop);
                    dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
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
                    HoSoHocSinhBUL hs = new HoSoHocSinhBUL();
                    string MaHocSinh = txtMaHS.Text;
                    hs.Xoa(MaHocSinh);

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

                    dgvHSHS.DataSource = myHSHS.LayDanhSachHoSoHocSinh();
                    ClearHoSoHocSinh();
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

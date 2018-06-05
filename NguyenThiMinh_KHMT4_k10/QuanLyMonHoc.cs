using BUL;
using DTO;
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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        MonHocBUL myMonHoc = new MonHocBUL();
  

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
          

            dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();

        }

        private void ClearMonHoc()
        {
            txtbMaMonHoc.Clear();
            txtbTenMon.Clear();
            txtbSoTiet.Clear();
        }

      


        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXem.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnXem.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDSMonHoc xemDS = new XemDSMonHoc();
            xemDS.Show();
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMonHoc();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                try
                {
                    MonHocBUL mh = new MonHocBUL();
                    string MaMon = txtbMaMonHoc.Text;
                    string TenMon = txtbTenMon.Text;
                    int SoTiet = int.Parse(txtbSoTiet.Text);
                    mh.Them(MaMon, TenMon, SoTiet);
                    dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
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
                    MonHocBUL mh = new MonHocBUL();
                    string MaMon = txtbMaMonHoc.Text;
                    string TenMon = txtbTenMon.Text;
                    int SoTiet = int.Parse(txtbSoTiet.Text);
                    mh.Sua(MaMon, TenMon, SoTiet);
                    dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
                    btnSua.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin  không hợp lệ!!!");
                }
            }
            if (btnXoa.Enabled == false)
            {

                try
                {
                    MonHocBUL mh = new MonHocBUL();
                    string MaMon = txtbMaMonHoc.Text;
                    mh.Xoa(MaMon);

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

                    dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
                    ClearMonHoc();
                    btnXoa.Enabled = true;
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

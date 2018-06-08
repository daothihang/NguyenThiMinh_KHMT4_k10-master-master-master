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
    public partial class QuanLyDiemGV : Form
    {
        public QuanLyDiemGV(String tengv)
        {
            InitializeComponent();
            lbtengv.Text = tengv;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        PhanCongGiangDayBUL mypc = new PhanCongGiangDayBUL();
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            cblop.DataSource = mypc.LayLopPhanCongTheoGv(lbtengv.Text);
            cblop.DisplayMember = "TenLop";
            cblop.SelectedIndex = -1;
            cblop.ValueMember = "MaLop";

            cbmon.DataSource = mypc.LayLopPhanCongTheoGv(lbtengv.Text);
            cbmon.DisplayMember = "TenMon";
            cbmon.SelectedIndex = -1;
            cbmon.ValueMember = "MaMon";
        }
        DiemBUL myDiem = new DiemBUL();
        private void btnnhapdiem_Click(object sender, EventArgs e)
        {
            dgvdshs.DataSource = myDiem.LayDSHocSinh((string)cblop.SelectedValue, (string)cbmon.SelectedValue);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int indexColum = dgvdshs.ColumnCount;
            if (indexColum == 4)
            {
                for (int i = 0; i < dgvdshs.RowCount; i++)
                {

                    if (dgvdshs.Rows[i].Cells[0].Value == null || dgvdshs.Rows[i].Cells[0].Value == DBNull.Value)
                    {
                        MessageBox.Show("Nhập điểm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        float diemky1 = float.Parse(dgvdshs.Rows[i].Cells["DiemTB_Ky1"].Value.ToString());
                        float diemky2 = float.Parse(dgvdshs.Rows[i].Cells["DiemTB_Ky2"].Value.ToString());
                        string mahs = dgvdshs.Rows[i].Cells["MaHocSinh"].Value.ToString();
                        string mamon = cbmon.SelectedValue.ToString();
                        myDiem.save(diemky1, diemky2, mahs, mamon);
                    }
                }
            }
            else if (indexColum == 6)
            {
                for (int i = 0; i < dgvdshs.RowCount; i++)
                {
                    if (dgvdshs.Rows[i].Cells[0].Value == null || dgvdshs.Rows[i].Cells[0].Value == DBNull.Value)
                    {
                        MessageBox.Show("Sửa điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        float diemky1moi = float.Parse(dgvdshs.Rows[i].Cells["ĐiểmTB_Ky1_Mới"].Value.ToString());
                        float diemky2moi = float.Parse(dgvdshs.Rows[i].Cells["ĐiểmTB_Ky2_Mới"].Value.ToString());
                        string mahs = dgvdshs.Rows[i].Cells["MaHocSinh"].Value.ToString();
                        string mamon = cbmon.SelectedValue.ToString();
                        myDiem.save(diemky1moi, diemky2moi, mahs, mamon);
                    }
                }
            }
           
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            dgvdshs.DataSource = myDiem.LayDSHocSinh((string)cblop.SelectedValue, (string)cbmon.SelectedValue);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataTable dt = myDiem.LayDSHocSinh((string)cblop.SelectedValue, (string)cbmon.SelectedValue);
            dt.Columns.Add(new DataColumn("ĐiểmTB_Ky1_Mới", typeof(float)));
            dt.Columns.Add(new DataColumn("ĐiểmTB_Ky2_Mới", typeof(float)));
            dgvdshs.DataSource = dt;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cblop.SelectedIndex = -1;
            cbmon.SelectedIndex = -1;
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemHoSoHocSinh hs = new XemHoSoHocSinh();
            hs.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doi_MK doimk = new Doi_MK();
            doimk.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong ht = new HeThong();
            ht.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGV gv = new FormGV(lbtengv.Text);
            gv.Show();
        }
    }
}

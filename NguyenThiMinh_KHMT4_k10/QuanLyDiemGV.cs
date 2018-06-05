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
            cblop.ValueMember = "MaLop";

            cbmon.DataSource = mypc.LayLopPhanCongTheoGv(lbtengv.Text);
            cbmon.DisplayMember = "TenMon";
            cbmon.ValueMember = "MaMon";
        }
    }
}

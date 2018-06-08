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
    public partial class FormGV : Form
    {
        public FormGV(String tengv)
        {
            InitializeComponent();
            lbtengv.Text = tengv;
        }
        
        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDiemGV diem = new QuanLyDiemGV(lbtengv.Text);
            diem.Show();
        }

        private void FormGV_Load(object sender, EventArgs e)
        {

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

        
    }
}

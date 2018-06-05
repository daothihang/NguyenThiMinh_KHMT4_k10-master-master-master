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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}
    }
}

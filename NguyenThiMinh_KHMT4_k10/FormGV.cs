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

            QuanLyDiemGV diem = new QuanLyDiemGV(lbtengv.Text);
            diem.Show();
        }

        private void FormGV_Load(object sender, EventArgs e)
        {

        }
    }
}

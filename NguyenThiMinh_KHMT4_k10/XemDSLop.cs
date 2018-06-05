using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class XemDSLop : Form
    {
        public XemDSLop()
        {
            InitializeComponent();
        }

        LopBUL myLopBUL = new LopBUL();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XemDSLop_Load(object sender, EventArgs e)
        {
            cbTen.DataSource = myLopBUL.LayDsLop();
            cbTen.DisplayMember = "TenLop";
            cbTen.ValueMember = "TenLop";
            dgvDSLop.DataSource = myLopBUL.LayDsLop();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == txtMaLop.Text)
            {
                LopBUL lp = new LopBUL();
                string MaLop = txtMaLop.Text;
                DataTable dt = lp.TimKiem(MaLop);
                dgvDSLop.DataSource = dt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbTen.Text == (string)cbTen.SelectedValue)
            {
                LopBUL lp = new LopBUL();
                string TenLop = cbTen.Text;
                DataTable dt = lp.TimKiem1(TenLop);
                dgvDSLop.DataSource = dt;
            }
            else
                dgvDSLop.DataSource = myLopBUL.LayDsLop();
                txtMaLop.Clear();
        }
    }
}

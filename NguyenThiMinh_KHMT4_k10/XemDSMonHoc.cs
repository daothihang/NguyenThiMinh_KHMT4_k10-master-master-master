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
    public partial class XemDSMonHoc : Form
    {
        public XemDSMonHoc()
        {
            InitializeComponent();
        }
        MonHocBUL myMonHoc = new MonHocBUL();
        private void XemDSMonHoc_Load(object sender, EventArgs e)
        {
            cbTenMon.DataSource = myMonHoc.LayDanhSachMonHoc();
            cbTenMon.DisplayMember = "TenMon";
            cbTenMon.ValueMember = "TenMon";
            dgvDSMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == txtMaMon.Text)
            {
                MonHocBUL monHoc = new MonHocBUL();
                string MaMon = txtMaMon.Text;
                DataTable dt = monHoc.TimKiem(MaMon);
                dgvDSMonHoc.DataSource = dt;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbTenMon.Text == (string)cbTenMon.SelectedValue)
            {
                MonHocBUL monHoc = new MonHocBUL();
                string TenMon = cbTenMon.Text;
                DataTable dt = monHoc.TimKiem1(TenMon);
                dgvDSMonHoc.DataSource = dt;

            }
            else
                dgvDSMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using DTO;
using System.Data.SqlClient;
using System.Configuration;
namespace NguyenThiMinh_KHMT4_k10
{
    public partial class XemHoSoHocSinh : Form
    {
        public XemHoSoHocSinh()
        {
            InitializeComponent();
        }
        HoSoHocSinhBUL myHSHS = new HoSoHocSinhBUL();
        private void XemHoSoHocSinh_Load(object sender, EventArgs e)
        {
       
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == txtMaHS.Text)
            {
                HoSoHocSinhBUL hoSoHocSinhBUL = new HoSoHocSinhBUL();
                string MaHocSinh = txtMaHS.Text;
                DataTable dt = hoSoHocSinhBUL.TimKiem(MaHocSinh);
                dgvHT.DataSource = dt;
            }
            else
                dgvHT.DataSource = myHSHS.LayDanhSachHoSoHocSinh();

            }
        }
    }


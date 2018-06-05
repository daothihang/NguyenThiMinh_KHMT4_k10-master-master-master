using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
using System.Data.SqlClient;
using System.Configuration;

namespace DaoThiHang_KHMT4_k10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["KETNOIQLHS"].ToString());
      
        MonHocBUL myMonHoc = new MonHocBUL();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aaaa
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlINSERT =
               "INSERT INTO MonHoc VALUES(@ma,@ten,@st)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
            cmd.Parameters.AddWithValue("ma", txtbMonHoc.Text);
            cmd.Parameters.AddWithValue("ten", txtbTenMon.Text);
            cmd.Parameters.AddWithValue("st", txtbSoTiet.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            dgvMonHoc.DataSource = myMonHoc.LayDanhSachMonHoc();

        }
    }
}

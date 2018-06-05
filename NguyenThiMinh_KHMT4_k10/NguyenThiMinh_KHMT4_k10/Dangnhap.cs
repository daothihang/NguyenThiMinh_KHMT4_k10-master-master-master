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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        LopBUL myLop = new LopBUL();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        CanBoGiaoVienBUL myCB = new CanBoGiaoVienBUL();
        private void btndnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = myCB.Login(txttendn.Text, txtmk.Text, cboloaitk.Text);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (cboloaitk.Text == "admin")
                {

                    this.Hide();
                    FormAdmin main = new FormAdmin();
                    main.Show();
                }
                else
                {

                    //this.Hide();
                    //FormMainGiaoVien maingv = new FormMainGiaoVien();
                    //maingv.Show();

                }

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void txtloaitk_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboloaitk_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboloaitk.DataSource = myCB.LayDsCanBo();
            cboloaitk.DisplayMember = "LoaiTaiKhoan";
            cboloaitk.ValueMember = "LoaiTaiKhoan";
          
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

    
      
      
    }
}

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
    public partial class Doi_MK : Form
    {
        public Doi_MK()
        {
            InitializeComponent();
        }

        private void btnthoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CanBoGiaoVienBUL myCb = new CanBoGiaoVienBUL();
        private void btndongy_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = myCb.ChangeMK(txttaikhoan2.Text, txtmatkhaucu2.Text);
            errorProvider1.Clear();

            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtmatkhaumoi2.Text == txtnhaplaimkmoi.Text)
                {
                    myCb.ChangingMK(txtmatkhaumoi2.Text, txttaikhoan2.Text, txtmatkhaucu2.Text);
                    MessageBox.Show("Đổi mật Khẩu Thành Công !", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    errorProvider1.SetError(txtmatkhaumoi2, "Không Đúng");
                    errorProvider1.SetError(txtnhaplaimkmoi, "Không Đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txttaikhoan2, "không đúng .");
                errorProvider1.SetError(txtmatkhaucu2, "không đúng .");
            }
        }
    }
}

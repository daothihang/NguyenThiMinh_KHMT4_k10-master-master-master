using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class CanBoGiaoVienBUL
    {
        CanBoGiaoVienDAL myCB = new CanBoGiaoVienDAL();
        public List<CanBoGiaoVienDTO> LayDsCanBo()
        {
            return myCB.LayBangCanBoGiaoVien();
        }

        public DataTable Login(String ten, String mk, String loaitk)
        {
            return myCB.dangnhap(ten, mk, loaitk);
        }
    }
}

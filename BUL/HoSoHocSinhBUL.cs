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
    public class HoSoHocSinhBUL
    {
        HoSoHocSinhDAL myHoSoHocSinhDAL = new HoSoHocSinhDAL();
        public List<HoSoHocSinhDTO> LayDanhSachHoSoHocSinh()
        {
            return myHoSoHocSinhDAL.LayBangHoSoHocSinh();
        }
        public bool Them(string MaHocSinh, string Hoten, string NgaySinh, string GioiTinh, string DiaChi,
           float DiemVaoTruong, string HoTenBoMe, string SoDienthoai, string MaLop)
        {
            return myHoSoHocSinhDAL.Them(MaHocSinh, Hoten, NgaySinh, GioiTinh, DiaChi, DiemVaoTruong,
                HoTenBoMe, SoDienthoai, MaLop);

        }
        public bool Sua(string MaHocSinh, string Hoten, string NgaySinh, string GioiTinh, string DiaChi,
         float DiemVaoTruong, string HoTenBoMe, string SoDienthoai, string MaLop)
        {
            return myHoSoHocSinhDAL.Sua(MaHocSinh, Hoten, NgaySinh, GioiTinh, DiaChi, DiemVaoTruong,
                HoTenBoMe, SoDienthoai, MaLop);

        }
        public bool Xoa(string MaHocSinh)
        {
            return myHoSoHocSinhDAL.Xoa(MaHocSinh);

        }
        public DataTable TimKiem(string MaHocSinh)
        {
            DataTable dt = myHoSoHocSinhDAL.TimKiem(MaHocSinh);
            return dt;
        }
        public DataTable LayGT()
        {
            return myHoSoHocSinhDAL.LayGT();
        }
    }
}

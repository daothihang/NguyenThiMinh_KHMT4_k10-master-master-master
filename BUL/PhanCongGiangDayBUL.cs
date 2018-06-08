using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUL
{
    public class PhanCongGiangDayBUL
    {

        PhanCongGiangDayDAL myPhanCongDAL = new PhanCongGiangDayDAL();
        public List<PhanCongGiangDayDTO> LayDanhSachPhanCongGiangDay()
        {
            return myPhanCongDAL.LayBangPhanCongGiangDay();
        }


        public void phanCong(String malop, String mamon, String macbgv, String ngaypc)
        {
            myPhanCongDAL.them(malop,mamon,macbgv,ngaypc);

        }
        public void sua(PhanCongGiangDayDTO dto)
        {
            myPhanCongDAL.sua(dto);
        }
        public DataTable DSPhanCongGiangDay(string TenLop)
        {
            DataTable dt = myPhanCongDAL.DSPhanCongGiangDay(TenLop);
            return dt;
        }

        public DataTable XemDsPhanCongTheoLop(string TenLop)
        {
            DataTable dt = myPhanCongDAL.XemDSPhanCongGiangDayTheoTLop(TenLop);
            return dt;
        }
        public DataTable XemDsPhanCongTheoMon(string TenMon)
        {
            DataTable dt = myPhanCongDAL.XemDSPhanCongGiangDayTheoMon(TenMon);
            return dt;
        }
        public DataTable XemDsPhanCongTheoGv(string TenGv)
        {
            DataTable dt = myPhanCongDAL.XemDSPhanCongGiangDayTheoGv(TenGv);
            return dt;
        }
        public DataTable LayLopPhanCongTheoGv(string TaiKhoan)
        {
            DataTable dt = myPhanCongDAL.layLopPhanCongTheoGv(TaiKhoan);
            return dt;
        }

        public void xoaPC(PhanCongGiangDayDTO dto)
        {
            myPhanCongDAL.xoa(dto);
        }
    }
}

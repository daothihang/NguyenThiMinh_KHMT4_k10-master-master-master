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
    public class LopBUL
    {
        LopDAL myLop = new LopDAL();
        public List<LopDTO> LayDsLop()
        {
            return myLop.LayBangLop();
        }
        public bool Them(string MaLop, string TenLop, string NienKhoa, int SiSo, string GiaoVienChuNhiem)
        {
            return myLop.Them(MaLop, TenLop, NienKhoa, SiSo, GiaoVienChuNhiem);
        }
        public bool Sua(string MaLop, string TenLop, string NienKhoa, int SiSo, string GiaoVienChuNhiem)
        {
            return myLop.Sua(MaLop, TenLop, NienKhoa, SiSo, GiaoVienChuNhiem);
        }
        public bool Xoa(string MaLop)
        {
            return myLop.Xoa(MaLop);
        }

        public DataTable TimKiem(string MaLop)
        {
            DataTable dt = myLop.TimKiem(MaLop);
            return dt;
        }

        public DataTable TimKiem(object maLop)
        {
            throw new NotImplementedException();
        }

        public DataTable TimKiem1(string TenLop)
        {
            DataTable dt = myLop.TimKiem1(TenLop);
            return dt;
        }
        public DataTable DanhSachHocSinh(string TenLop)
        {
            DataTable dt = myLop.DanhSachHocSinh(TenLop);
            return dt;
        }
    }
}

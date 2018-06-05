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
    public class MonHocBUL
    {
        MonHocDAL myMonHoc = new MonHocDAL();
        public List<MonHocDTO> LayDanhSachMonHoc()
        {
            return myMonHoc.LayBangMonHoc();
        }
        public bool Them( string MaMon, string TenMon, int SoTiet)
        {
            return myMonHoc.Them(MaMon, TenMon, SoTiet);

        }
        public bool Sua(string MaMon, string TenMon, int SoTiet)
        {
            return myMonHoc.Sua(MaMon, TenMon, SoTiet);

        }
        public bool Xoa(string MaMon)
        {
            return myMonHoc.Xoa(MaMon);

        }
        public DataTable TimKiem(string MaMon)
        {
            DataTable dt = myMonHoc.TimKiem(MaMon);
            return dt;
        }

        public DataTable TimKiem1(string TenMon)
        {
            DataTable dt = myMonHoc.TimKiem1(TenMon);
            return dt;
        }

    }
}

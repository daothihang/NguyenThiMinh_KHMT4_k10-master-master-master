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
    public class DiemBUL
    {
        DiemDAL myDiemDAL = new DiemDAL();
        public List<DiemDTO> LayDanhSachDiem()
        {
            return myDiemDAL.LayBangDiem();
        }
        public DataTable LayDSHocSinh(String MaLop,String MaMon)
        {
            return myDiemDAL.DSHocSinh(MaLop, MaMon);
        }

        public void save(float diemky1, float diemky2,string mahs,string mamon)
        {
            myDiemDAL.sua(diemky1,diemky2,mahs,mamon);
        }

    }
}

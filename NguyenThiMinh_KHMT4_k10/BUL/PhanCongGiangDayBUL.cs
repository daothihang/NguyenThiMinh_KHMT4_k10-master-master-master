using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class PhanCongGiangDayBUL
    {

        PhanCongGiangDayDAL myPhanCongDAL = new PhanCongGiangDayDAL();
        public List<PhanCongGiangDayDTO> LayDanhSachPhanCongGiangDay()
        {
            return myPhanCongDAL.LayBangPhanCongGiangDay();
        }
		
    }
}

using System;
using System.Collections.Generic;
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

    }
}

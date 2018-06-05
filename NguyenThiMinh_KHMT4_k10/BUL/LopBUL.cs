using System;
using System.Collections.Generic;
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

    }
}

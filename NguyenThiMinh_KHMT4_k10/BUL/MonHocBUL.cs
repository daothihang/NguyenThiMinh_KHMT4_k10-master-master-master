using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class MonHocBUL
    {
        MonHocDAL myMonHoc = new MonHocDAL();
        public List<MonHocDTO> LayDanhSachMonHoc()
        {
            return myMonHoc.LayBangMonHoc();
        }
        
	
    }
}

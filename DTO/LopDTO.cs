using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public int SiSo { get; set; }
        public string NienKhoa { get; set; }
        public string GiaoVienChuNhiem { get; set; }
       
   
        public LopDTO() { }

        public LopDTO(string malop, string tenlop, string nienkhoa, int siso, string gvcn)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;
            this.SiSo = siso;
            this.NienKhoa = nienkhoa;
            this.GiaoVienChuNhiem = gvcn;



        }
    }
}

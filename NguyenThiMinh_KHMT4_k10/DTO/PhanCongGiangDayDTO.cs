using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongGiangDayDTO
    {

        public string MaLop { get; set; }
        public string MaMon { get; set; }
        public string MaCanBoGiaoVien { get; set; }
        public string NgayPhanCong { get; set; }
      
        public PhanCongGiangDayDTO() { }

        public PhanCongGiangDayDTO(string malop, string mamon, string macanbogv, string ngaypc)
        {
            this.MaLop = malop;
            this.MaMon = mamon;
            this.MaCanBoGiaoVien = macanbogv;
            this.NgayPhanCong = ngaypc;

        }

    }
}

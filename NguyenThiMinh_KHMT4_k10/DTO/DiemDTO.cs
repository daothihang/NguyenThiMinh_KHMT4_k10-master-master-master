using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDTO
    {

        public string MaHocSinh { get; set; }
        public string MaMonHoc { get; set; }
        public float DiemTB_Ky1 { get; set; }
        public float DiemTB_Ky2 { get; set; }


        public DiemDTO() { }

        public DiemDTO(string mahocsinh, string mamonhoc, float diemtb_ky1, float diemtb_ky2)
        {
            this.MaHocSinh = mahocsinh;
            this.MaMonHoc = mamonhoc;
            this.DiemTB_Ky1 = diemtb_ky1;
            this.DiemTB_Ky2 = diemtb_ky2;
        }
    }
}

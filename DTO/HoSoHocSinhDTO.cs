using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoSoHocSinhDTO
    {

        public string MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public float DiemVaoTruong { get; set; }
        public string HoTenBoMe { get; set; }
        public string SoDienThoai { get; set; }
        public string MaLop { get; set; }
        public HoSoHocSinhDTO() { }

        public HoSoHocSinhDTO(string mahocsinh, string hoten, string ngaysinh, string gioitinh,
            string diachi, float diemvaotruong, string hotenbome, string sodienthoai, string malop)
        {
            this.MaHocSinh = mahocsinh;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.DiaChi = diachi;
            this.DiemVaoTruong = diemvaotruong;
            this.HoTenBoMe = hotenbome;
            this.SoDienThoai = sodienthoai;
            this.MaLop = malop;
        }
    }
}

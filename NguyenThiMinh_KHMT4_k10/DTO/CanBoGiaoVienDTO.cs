using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CanBoGiaoVienDTO
    {
        public string MaCanBoGiaoVien { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTaiKhoan { get; set; }

        public CanBoGiaoVienDTO() { }
        public CanBoGiaoVienDTO(string ma, string ten, string diachi, string sodt, string taikhoan, string matkhau, string loaitk)
        {
            this.MaCanBoGiaoVien = ma;
            this.HoTen = ten;
            this.DiaChi = diachi;
            this.SoDienThoai = sodt;
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaitk;
        }
    }
}

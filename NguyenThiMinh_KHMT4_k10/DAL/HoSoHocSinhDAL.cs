using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class HoSoHocSinhDAL
    {

        public List<HoSoHocSinhDTO> LayBangHoSoHocSinh()
        {
            List<HoSoHocSinhDTO> ds = new List<HoSoHocSinhDTO>();
            KetNoiCoSoDuLieu.MoKetNoi();
            string sqlSELECT = "SELECT * FROM HoSoHocSinh";
            SqlCommand cmd = new SqlCommand(sqlSELECT, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoSoHocSinhDTO hshs = new HoSoHocSinhDTO(
                    dr["MaHocSinh"].ToString(),
                    dr["HoTen"].ToString(),
                    dr["NgaySinh"].ToString(),
                    dr["GioiTinh"].ToString(),
                    dr["DiaChi"].ToString(),
                    Convert.ToInt32(dr["DiemVaoTruong"]),
                    dr["HoTenBoMe"].ToString(),
                    dr["SoDienThoai"].ToString(),
                    dr["MaLop"].ToString());
                ds.Add(hshs);
            }
            KetNoiCoSoDuLieu.DongKetNoi();
            return ds;

        }
    }
}

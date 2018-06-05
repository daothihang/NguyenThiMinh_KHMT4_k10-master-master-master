using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhanCongGiangDayDAL
    {

        public List<PhanCongGiangDayDTO> LayBangPhanCongGiangDay()
        {
            List<PhanCongGiangDayDTO> dspcgd = new List<PhanCongGiangDayDTO>();
            KetNoiCoSoDuLieu.MoKetNoi();
            string sqlSELECT = "SELECT * FROM PhanCongGiangDay";
            SqlCommand cmd = new SqlCommand(sqlSELECT, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                PhanCongGiangDayDTO pcgd = new PhanCongGiangDayDTO(
                     dr["MaLop"].ToString(),
                     dr["MaMon"].ToString(),
                     dr["MaCanBoGV"].ToString(),
                     dr["NgayPhanCong"].ToString());

                dspcgd.Add(pcgd);
            }
            KetNoiCoSoDuLieu.DongKetNoi();
            return dspcgd;
        }
		
    }
}

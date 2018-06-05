using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DiemDAL
    {
        public List<DiemDTO> LayBangDiem()
        {
            List<DiemDTO> ds = new List<DiemDTO>();
            KetNoiCoSoDuLieu.MoKetNoi();
            string sqlSELECT = "SELECT * FROM Diem";
            SqlCommand cmd = new SqlCommand(sqlSELECT, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DiemDTO diem = new DiemDTO(
                    dr["MaHocSinh"].ToString(),
                    dr["MaMonHoc"].ToString(),
                    Convert.ToInt32(dr["DiemTB_Ky1"]),
                     Convert.ToInt32(dr["DiemTB_ky2"]));
                ds.Add(diem);
            }
            KetNoiCoSoDuLieu.DongKetNoi();
            return ds;

        }
    }
}

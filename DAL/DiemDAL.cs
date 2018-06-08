using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable DSHocSinh(string MaLop,string MaMon)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select HoSoHocSinh.MaHocSinh,HoSoHocSinh.HoTen, Diem.DiemTB_Ky1,Diem.DiemTB_Ky2 from Diem inner join HoSoHocSinh on Diem.MaHocSinh= HoSoHocSinh.MaHocSinh inner join PhanCongGiangDay on Diem.MaMonHoc= PhanCongGiangDay.MaMon inner join MonHoc on Diem.MaMonHoc= MonHoc.MaMon where PhanCongGiangDay.MaLop like'" + MaLop + "%' and PhanCongGiangDay.MaMon like'" + MaMon+"%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }


        public void sua(float diemky1,float diemky2,string mahs,string mamon)
        {
            KetNoiCoSoDuLieu.MoKetNoi();

            String sqlsua = "UPDATE Diem SET DiemTB_Ky1=@diemky1, DiemTB_Ky2=@diemky2 where MaHocSinh=@mahs and MaMonHoc=@mamon";
            SqlCommand cmd = new SqlCommand(sqlsua, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("diemky1", diemky1);
            cmd.Parameters.AddWithValue("diemky2", diemky2);
            cmd.Parameters.AddWithValue("mahs", mahs);
            cmd.Parameters.AddWithValue("mamon", mamon);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();

        }
    }
}

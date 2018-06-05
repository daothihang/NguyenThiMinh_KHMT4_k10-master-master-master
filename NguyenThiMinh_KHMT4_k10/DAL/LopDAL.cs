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
    public class LopDAL
    {
        private SqlConnection conn=KetNoiCoSoDuLieu.KetNoi;

        public List<LopDTO> LayBangLop()
        {
            List<LopDTO> ds = new List<LopDTO>();

            KetNoiCoSoDuLieu.MoKetNoi();
            String sql = "SELECT*FROM Lop";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LopDTO hh = new LopDTO(dr["MaLop"].ToString(), dr["TenLop"].ToString(),
                    dr["NienKhoa"].ToString(), Convert.ToInt32(dr["SiSo"]), dr["GiaoVienChuNhiem"].ToString());

                ds.Add(hh);
            }


            KetNoiCoSoDuLieu.DongKetNoi();
            return ds;
        }
       public void insert(){
           List<LopDTO> ds = new List<LopDTO>();
           KetNoiCoSoDuLieu.MoKetNoi();
           string sqlINSERT = 
               "INSERT INTO Lop VALUES(@ma,@ten,@st)";
           SqlCommand cmd = new SqlCommand(sqlINSERT, KetNoiCoSoDuLieu.KetNoi);
           SqlDataReader dr = cmd.ExecuteReader();

           while (dr.Read())
           {
               LopDTO hh1 = new LopDTO(dr["MaLop"].ToString(), dr["TenLop"].ToString(),
                   dr["NienKhoa"].ToString(), Convert.ToInt32(dr["SiSo"]), dr["GiaoVienChuNhiem"].ToString());
               ds.Add(hh1);
           } 
           //cmd.Parameters.AddWithValue("ma",txtbMonHoc.Text);
           cmd.ExecuteNonQuery();
           KetNoiCoSoDuLieu.DongKetNoi();
            
       }
    }
}

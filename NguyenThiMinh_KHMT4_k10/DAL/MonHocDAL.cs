using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class MonHocDAL
    {

        public List<MonHocDTO> LayBangMonHoc()
        {
            List<MonHocDTO> dsmh = new List<MonHocDTO>();
            KetNoiCoSoDuLieu.MoKetNoi();
            string sqlSELECT = "SELECT * FROM MonHoc";
            SqlCommand cmd = new SqlCommand(sqlSELECT, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                MonHocDTO mh = new MonHocDTO(
                     dr["MaMon"].ToString(),
                     dr["TenMon"].ToString(),
                     Convert.ToInt32(dr["SoTiet"]));

                dsmh.Add(mh);
            }
            KetNoiCoSoDuLieu.DongKetNoi();
            return dsmh;
        }
        //private static From1 from1;
        public void insert()
        {
            
            List<MonHocDTO> ds = new List<MonHocDTO>();
            KetNoiCoSoDuLieu.MoKetNoi();
            string sqlINSERT =
                "INSERT INTO MonHoc VALUES(@ma,@ten,@st)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MonHocDTO hh1 = new MonHocDTO(dr["MaMon"].ToString(), dr["TenMon"].ToString(),
                     Convert.ToInt32(dr["SoTiet"]));
                ds.Add(hh1);
            }
            //cmd.Parameters.AddWithValue("ma",MonHocDAL.from1.ToString);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();

        }
    }
}

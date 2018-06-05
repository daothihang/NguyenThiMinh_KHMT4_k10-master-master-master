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
        public bool Them( string MaMon, string TenMon, int SoTiet)
        {
            try
            {
                List<MonHocDTO> dsMonHoc = new List<MonHocDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlInsert = "insert into MonHoc values(@MaMon, @TenMon, @SoTiet)";
                SqlCommand cmd = new SqlCommand(sqlInsert, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaMon", SqlDbType.NVarChar).Value = MaMon;
                cmd.Parameters.AddWithValue("@TenMon", SqlDbType.NVarChar).Value = TenMon;
                cmd.Parameters.AddWithValue("@SoTiet", SqlDbType.Int).Value = SoTiet;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                KetNoiCoSoDuLieu.DongKetNoi();
            }
            return false;
        }
        public bool Sua(string MaMon, string TenMon, int SoTiet)
        {
            try
            {
                List<MonHocDTO> dsMonHoc = new List<MonHocDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlUpdate = "update  MonHoc set  TenMon=@TenMon, SoTiet=@SoTiet where MaMon=@MaMon";
                SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaMon", SqlDbType.NVarChar).Value = MaMon;
                cmd.Parameters.AddWithValue("@TenMon", SqlDbType.NVarChar).Value = TenMon;
                cmd.Parameters.AddWithValue("@SoTiet", SqlDbType.Int).Value = SoTiet;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                KetNoiCoSoDuLieu.DongKetNoi();
            }
            return false;
        }
        public bool Xoa(string MaMon)
        {
            try
            {
                List<MonHocDTO> dsMonHoc = new List<MonHocDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlDelete = "delete from  MonHoc  where MaMon=@MaMon";
                SqlCommand cmd = new SqlCommand(sqlDelete, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaMon", SqlDbType.NVarChar).Value = MaMon;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                KetNoiCoSoDuLieu.DongKetNoi();
            }
            return false;
        }

        public DataTable TimKiem(string MaMon)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select  MaMon,TenMon,SoTiet from MonHoc where  MaMon like '" + MaMon + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }
        public DataTable TimKiem1(string TenMon)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select  MaMon,TenMon,SoTiet from MonHoc where  TenMon like '" + TenMon + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }

    }
}

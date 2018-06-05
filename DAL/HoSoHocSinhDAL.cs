using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
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
        public bool Them(string MaHocSinh, string HoTen, string NgaySinh, string GioiTinh, string DiaChi,
            float DiemVaoTruong, string HoTenBoMe, string SoDienthoai, string MaLop)
        {
            try
            {
                List<HoSoHocSinhDTO> hshs = new List<HoSoHocSinhDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlInsert = "insert into HoSoHocSinh values(@MaHocSinh, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DiemVaoTruong, @HoTenBoMe, @SoDienthoai, @MaLop)";
                SqlCommand cmd = new SqlCommand(sqlInsert, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaHocSinh", SqlDbType.NVarChar).Value = MaHocSinh;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = HoTen;
                cmd.Parameters.AddWithValue("@NgaySinh", SqlDbType.NVarChar).Value = NgaySinh;
                cmd.Parameters.AddWithValue("@GioiTinh", SqlDbType.NVarChar).Value = GioiTinh;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = DiaChi;
                cmd.Parameters.AddWithValue("@DiemVaoTruong", SqlDbType.Float).Value = DiemVaoTruong;
                cmd.Parameters.AddWithValue("@HoTenBoMe", SqlDbType.NVarChar).Value = HoTenBoMe;
                cmd.Parameters.AddWithValue("@SoDienthoai", SqlDbType.NVarChar).Value = SoDienthoai;
                cmd.Parameters.AddWithValue("@MaLop", SqlDbType.NVarChar).Value = MaLop;
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
        public bool Sua(string MaHocSinh, string Hoten, string NgaySinh, string GioiTinh, string DiaChi,
            float DiemVaoTruong, string HoTenBoMe, string SoDienthoai, string MaLop)
        {
            try
            {
                List<HoSoHocSinhDTO> hshs = new List<HoSoHocSinhDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlUpdate = "update  HoSoHocSinh set  MaHocSinh=@ma, HoTen=@ten, NgaySinh= @ns, GioiTinh=@gt, DiaChi=@dc, DiemVaoTruong=@diemvt, HoTenBoMe=@tenbm, SoDienThoai=@sdt, MaLop=@malop where MaHocSinh=@ma";
                SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@ma", SqlDbType.NVarChar).Value = MaHocSinh;
                cmd.Parameters.AddWithValue("@ten", SqlDbType.NVarChar).Value = Hoten;
                cmd.Parameters.AddWithValue("@ns", SqlDbType.NVarChar).Value = NgaySinh;
                cmd.Parameters.AddWithValue("@gt", SqlDbType.NVarChar).Value = GioiTinh;
                cmd.Parameters.AddWithValue("@dc", SqlDbType.NVarChar).Value = DiaChi;
                cmd.Parameters.AddWithValue("@diemvt", SqlDbType.Float).Value = DiemVaoTruong;
                cmd.Parameters.AddWithValue("@tenbm", SqlDbType.NVarChar).Value = HoTenBoMe;
                cmd.Parameters.AddWithValue("@sdt", SqlDbType.NVarChar).Value = SoDienthoai;
                cmd.Parameters.AddWithValue("@malop", SqlDbType.NVarChar).Value = MaLop;
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
        public bool Xoa(string MaHocSinh)
        {
            try
            {
                List<HoSoHocSinhDTO> hshs = new List<HoSoHocSinhDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlDelete = "delete from  HoSoHocSinh  where MaHocSinh=@ma";
                SqlCommand cmd = new SqlCommand(sqlDelete, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@ma", SqlDbType.NVarChar).Value = MaHocSinh;
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
        public DataTable TimKiem(string MaHocSinh)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select  MaHocSinh, NgaySinh,GioiTinh, DiaChi, DiemVaoTruong, HoTenBoMe, SoDienThoai, MaLop from HoSoHocSinh where MaHocSinh like '" + MaHocSinh + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;

        }
        public DataTable LayGT()
        {
            KetNoiCoSoDuLieu.MoKetNoi();
            DataTable dt = new DataTable();
            String sql = "SELECT DISTINCT GioiTinh FROM HoSoHocSinh ORDER BY GioiTinh ";
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;

        }
    }
}

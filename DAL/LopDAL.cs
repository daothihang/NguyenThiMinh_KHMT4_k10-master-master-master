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
                    dr["NienKhoa"].ToString(), Convert.ToInt32(dr["SiSo"]),
                    dr["GiaoVienChuNhiem"].ToString());

                ds.Add(hh);
                
            }


            KetNoiCoSoDuLieu.DongKetNoi();
            return ds;
        }
        public bool Them(string MaLop, string TenLop, string NienKhoa, int SiSo, string GiaoVienChuNhiem)
        {
            try
            {
                List<LopDTO> dsLop = new List<LopDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlInsert = "insert into Lop values(@MaLop, @TenLop, @NienKhoa,@SiSo,@GiaoVienChuNhiem)";
                SqlCommand cmd = new SqlCommand(sqlInsert, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaLop", SqlDbType.NVarChar).Value = MaLop;
                cmd.Parameters.AddWithValue("@TenLop", SqlDbType.NVarChar).Value = TenLop;
                cmd.Parameters.AddWithValue("@NienKhoa", SqlDbType.NVarChar).Value = NienKhoa;
                cmd.Parameters.AddWithValue("@SiSo", SqlDbType.Int).Value = SiSo;
                cmd.Parameters.AddWithValue("@GiaoVienChuNhiem", SqlDbType.NVarChar).Value = GiaoVienChuNhiem;
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
        public bool Sua(string MaLop, string TenLop, string NienKhoa, int SiSo, string GiaoVienChuNhiem)
        {
            try
            {
                List<LopDTO> dsLop = new List<LopDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlUpdate = "update  Lop set TenLop=@TenLop, NienKhoa=@NienKhoa,SiSo=@SiSo,GiaoVienChuNhiem=@GiaoVienChuNhiem where MaLop=@MaLop";
                SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaLop", SqlDbType.NVarChar).Value = MaLop;
                cmd.Parameters.AddWithValue("@TenLop", SqlDbType.NVarChar).Value = TenLop;
                cmd.Parameters.AddWithValue("@NienKhoa", SqlDbType.NVarChar).Value = NienKhoa;
                cmd.Parameters.AddWithValue("@SiSo", SqlDbType.Int).Value = SiSo;
                cmd.Parameters.AddWithValue("@GiaoVienChuNhiem", SqlDbType.NVarChar).Value = GiaoVienChuNhiem;
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

        public bool Xoa(string MaLop)
        {
            try
            {
                List<LopDTO> dsLop = new List<LopDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlDelete = "delete from  Lop  where MaLop=@MaLop";
                SqlCommand cmd = new SqlCommand(sqlDelete, KetNoiCoSoDuLieu.KetNoi);
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
        public DataTable TimKiem(string MaLop)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select MaLop, TenLop, NienKhoa, SiSo, GiaoVienChuNhiem from Lop where MaLop like '" + MaLop + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }
        public DataTable TimKiem1(string TenLop)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select  MaLop,TenLop,NienKhoa,SiSo,GiaoVienChuNhiem from Lop where  TenLop like '" + TenLop + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }

        public DataTable DanhSachHocSinh(string TenLop)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select Lop.TenLop,HoSoHocSinh.MaHocSinh,HoSoHocSinh.HoTen,HoSoHocSinh.GioiTinh,HoSoHocSinh.DiaChi,HoSoHocSinh.HoTenBoMe,HoSoHocSinh.SoDienThoai from Lop inner join HoSoHocSinh on Lop.MaLop=HoSoHocSinh.MaLop where TenLop like'" + TenLop+ "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }
       

    }
    

}

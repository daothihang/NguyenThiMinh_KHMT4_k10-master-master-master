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
    public class CanBoGiaoVienDAL
    {
        
        public List<CanBoGiaoVienDTO> LayBangCanBoGiaoVien()
        {
            List<CanBoGiaoVienDTO> dscb = new List<CanBoGiaoVienDTO>();

            KetNoiCoSoDuLieu.MoKetNoi();
            String sql = "SELECT*FROM CanBoGiaoVien";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCoSoDuLieu.KetNoi);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CanBoGiaoVienDTO cb = new CanBoGiaoVienDTO(dr["MaCanBoGiaoVien"].ToString(), dr["HoTen"].ToString(),
                    dr["DiaChi"].ToString(),dr["SoDienThoai"].ToString(), dr["TaiKhoan"].ToString(),dr["MatKhau"].ToString(),dr["LoaiTaiKhoan"].ToString());

                dscb.Add(cb);
            }


            KetNoiCoSoDuLieu.DongKetNoi();
            return dscb;
        }
        public DataTable dangnhap(String ten, String mk, String loaitk)
        {

            KetNoiCoSoDuLieu.MoKetNoi();
           

            String kiemtra = "SELECT COUNT(*) FROM CanBoGiaoVien WHERE TaiKhoan='" + ten + "'AND MatKhau='" + mk + "' AND LoaiTaiKhoan='" + loaitk + "' COLLATE SQL_Latin1_General_CP1_CI_AS";
            SqlDataAdapter cmd = new SqlDataAdapter(kiemtra, KetNoiCoSoDuLieu.KetNoi);
            DataTable dt = new DataTable();

            cmd.Fill(dt);

          
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }
        public bool Them(string MaCanBoGiaoVien, string HoTen, string DiaChi, string SoDienThoai, string TaiKhoan, string MatKhau, string LoaiTaiKhoan)
        {
            try
            {
                List<CanBoGiaoVienDTO> cbgv = new List<CanBoGiaoVienDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlInsert = "insert into CanBoGiaoVien values(@MaCanBoGiaoVien, @HoTen, @DiaChi, @SoDienThoai, @TaiKhoan, @MatKhau, @LoaiTaiKhoan)";
                SqlCommand cmd = new SqlCommand(sqlInsert, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", SqlDbType.NVarChar).Value = MaCanBoGiaoVien;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = HoTen;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = DiaChi;
                cmd.Parameters.AddWithValue("@SoDienThoai", SqlDbType.NVarChar).Value = SoDienThoai;
                cmd.Parameters.AddWithValue("@TaiKhoan", SqlDbType.NVarChar).Value = TaiKhoan;             
                cmd.Parameters.AddWithValue("@MatKhau", SqlDbType.NVarChar).Value = MatKhau;
                cmd.Parameters.AddWithValue("@LoaiTaiKhoan", SqlDbType.NVarChar).Value = LoaiTaiKhoan;
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
        public bool Sua(string MaCanBoGiaoVien, string HoTen, string DiaChi, string SoDienThoai, string TaiKhoan, string MatKhau, string LoaiTaiKhoan)
        {
            try
            {
                List<CanBoGiaoVienDTO> cbgv = new List<CanBoGiaoVienDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlUpdate = "update CanBoGiaoVien set  MaCanBoGiaoVien=@MaCanBoGiaoVien, HoTen=@HoTen, DiaChi= @DiaChi, SoDienThoai=@SoDienThoai, TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, LoaiTaiKhoan=@LoaiTaiKhoan where MaCanBoGiaoVien=@MaCanBoGiaoVien";
                SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", SqlDbType.NVarChar).Value = MaCanBoGiaoVien;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = HoTen;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = DiaChi;
                cmd.Parameters.AddWithValue("@SoDienThoai", SqlDbType.NVarChar).Value = SoDienThoai;
                cmd.Parameters.AddWithValue("@TaiKhoan", SqlDbType.NVarChar).Value = TaiKhoan;
                cmd.Parameters.AddWithValue("@MatKhau", SqlDbType.NVarChar).Value = MatKhau;
                cmd.Parameters.AddWithValue("@LoaiTaiKhoan", SqlDbType.NVarChar).Value = LoaiTaiKhoan;
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
        public bool Xoa(string MaCanBoGiaoVien)
        {
            try
            {
                List<HoSoHocSinhDTO> hshs = new List<HoSoHocSinhDTO>();
                KetNoiCoSoDuLieu.MoKetNoi();
                String sqlDelete = "delete from  CanBoGiaoVien  where MaCanBoGiaoVien=@MaCanBoGiaoVien";
                SqlCommand cmd = new SqlCommand(sqlDelete, KetNoiCoSoDuLieu.KetNoi);
                cmd.Parameters.AddWithValue("@MaCanBoGiaoVien", SqlDbType.NVarChar).Value = MaCanBoGiaoVien;
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
        public DataTable TimKiem(string MaCanBoGiaoVien)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select  MaCanBoGiaoVien, HoTen ,DiaChi, SoDienThoai, TaiKhoan, MatKhau, LoaiTaiKhoan from CanBoGiaoVien where MaCanBoGiaoVien like '" + MaCanBoGiaoVien + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }
        public DataTable doimk(String taikhoan2, String mkcu)
        {

            KetNoiCoSoDuLieu.MoKetNoi();
            SqlDataAdapter ASDF = new SqlDataAdapter("SELECT COUNT(*) FROM CanBoGiaoVien WHERE TaiKhoan='" + taikhoan2 + "' AND MatKhau='" + mkcu + "'", KetNoiCoSoDuLieu.KetNoi);
            DataTable dt = new DataTable();
            ASDF.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }

        public void thaydoimk(String mkmoi, String tk2, String mkcu)
        {
            KetNoiCoSoDuLieu.MoKetNoi();
            String cc = "UPDATE CanBoGiaoVien SET MatKhau=@mkmoi WHERE TaiKhoan=@tk2 AND MatKhau=@mkcu";


            SqlCommand cmd = new SqlCommand(cc, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("mkmoi", mkmoi);
            cmd.Parameters.AddWithValue("tk2", tk2);
            cmd.Parameters.AddWithValue("mkcu", mkcu);


            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();
        }


        public DataTable LayLoaiTK()
        {
            KetNoiCoSoDuLieu.MoKetNoi();
            DataTable dt = new DataTable();
            String sql = "SELECT DISTINCT LoaiTaiKhoan FROM CanBoGiaoVien ORDER BY LoaiTaiKhoan ";
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
      
        }
    }
}

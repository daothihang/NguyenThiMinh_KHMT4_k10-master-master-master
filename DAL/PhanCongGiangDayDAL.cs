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
                     dr["MaCanBoGiaoVien"].ToString(),
                     dr["NgayPhanCong"].ToString());

                dspcgd.Add(pcgd);
            }
            KetNoiCoSoDuLieu.DongKetNoi();
            return dspcgd;
        }

        public void them(String malop,String mamon,String macbgv,String ngaypc)
        {

            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlthem = "INSERT INTO PhanCongGiangDay VALUES(@malop,@mamon,@Macbgv,@ngaypc)";
            SqlCommand cmd = new SqlCommand(sqlthem, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("malop", malop);
            cmd.Parameters.AddWithValue("mamon", mamon);
            cmd.Parameters.AddWithValue("Macbgv", macbgv);
            cmd.Parameters.AddWithValue("ngaypc", ngaypc);

            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();
        }

        public void sua(PhanCongGiangDayDTO dto)
        {
           KetNoiCoSoDuLieu.MoKetNoi();

            String sqlsua = "UPDATE PhanCongGiangDay SET NgayPhanCong=@ngaypc WHERE MaLop=@malop AND MaMon=@mamon AND MaCanBoGiaoVien=@macbgv";
            SqlCommand cmd = new SqlCommand(sqlsua, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("malop", dto.MaLop);
            cmd.Parameters.AddWithValue("mamon", dto.MaMon);
            cmd.Parameters.AddWithValue("macbgv", dto.MaCanBoGiaoVien);
            cmd.Parameters.AddWithValue("ngaypc", dto.NgayPhanCong);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();

        }
        public DataTable DSPhanCongGiangDay(string TenLop)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select  MonHoc.TenMon, CanBoGiaoVien.MaCanBoGiaoVien , CanBoGiaoVien.HoTen , CanBoGiaoVien.SoDienthoai , PhanCongGiangDay.NgayPhanCong from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien= CanBoGiaoVien.MaCanBoGiaoVien inner join MonHoc on PhanCongGiangDay.MaMon= MonHoc.MaMon inner join Lop on PhanCongGiangDay.MaLop= Lop.MaLop where TenLop like'" + TenLop + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }


        public DataTable XemDSPhanCongGiangDayTheoTLop(string TenLop)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind = string.Format("select MonHoc.MaMon as 'Mã Môn', MonHoc.TenMon as 'Tên Môn',CanBoGiaoVien.MaCanBoGiaoVien as 'Mã CBGV', CanBoGiaoVien.HoTen as 'Họ Tên', CanBoGiaoVien.SoDienthoai as 'SĐT', PhanCongGiangDay.NgayPhanCong as 'Ngày PhCông' from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien= CanBoGiaoVien.MaCanBoGiaoVien inner join MonHoc on PhanCongGiangDay.MaMon= MonHoc.MaMon inner join Lop on PhanCongGiangDay.MaLop= Lop.MaLop where TenLop like'" + TenLop + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }

        public DataTable XemDSPhanCongGiangDayTheoMon(string TenMon)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind1 = string.Format("select Lop.MaLop as 'Mã Lớp',Lop.TenLop as 'Tên Lớp',CanBoGiaoVien.MaCanBoGiaoVien as 'Mã CBGV', CanBoGiaoVien.HoTen as 'Họ Tên', CanBoGiaoVien.SoDienthoai as 'SĐT', PhanCongGiangDay.NgayPhanCong as 'Ngày PhCông' from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien= CanBoGiaoVien.MaCanBoGiaoVien inner join MonHoc on PhanCongGiangDay.MaMon= MonHoc.MaMon inner join Lop on PhanCongGiangDay.MaLop= Lop.MaLop where TenMon like'" + TenMon + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind1, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }

        public DataTable XemDSPhanCongGiangDayTheoGv(string TenGV)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind2 = string.Format("select Lop.MaLop as 'Mã Lớp' ,Lop.TenLop as 'Tên Lớp' , MonHoc.MaMon as 'Mã Môn', MonHoc.TenMon as 'Tên Môn', PhanCongGiangDay.NgayPhanCong as 'Ngày PhCông' from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien= CanBoGiaoVien.MaCanBoGiaoVien inner join MonHoc on PhanCongGiangDay.MaMon= MonHoc.MaMon inner join Lop on PhanCongGiangDay.MaLop= Lop.MaLop where HoTen like'" + TenGV + "%' ");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind2, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }

        public DataTable layLopPhanCongTheoGv(string TaiKhoan)
        {
            DataTable dt = new DataTable();
            KetNoiCoSoDuLieu.MoKetNoi();
            String sqlFind3 = string.Format("select DISTINCT Lop.MaLop, Lop.TenLop, MonHoc.MaMon, MonHoc.TenMon from PhanCongGiangDay inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGiaoVien= CanBoGiaoVien.MaCanBoGiaoVien inner join MonHoc on PhanCongGiangDay.MaMon= MonHoc.MaMon inner join Lop on PhanCongGiangDay.MaLop= Lop.MaLop  where TaiKhoan like'" + TaiKhoan + "%'");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind3, KetNoiCoSoDuLieu.KetNoi);
            da.Fill(dt);
            KetNoiCoSoDuLieu.DongKetNoi();
            return dt;
        }



        public void xoa(PhanCongGiangDayDTO dto)
        {
            KetNoiCoSoDuLieu.MoKetNoi();

            String sqlsua = "Delete PhanCongGiangDay where MaLop=@malop AND MaMon=@mamon AND MaCanBoGiaoVien=@macbgv";
            SqlCommand cmd = new SqlCommand(sqlsua, KetNoiCoSoDuLieu.KetNoi);

            cmd.Parameters.AddWithValue("malop", dto.MaLop);
            cmd.Parameters.AddWithValue("mamon", dto.MaMon);
            cmd.Parameters.AddWithValue("macbgv", dto.MaCanBoGiaoVien);
            cmd.ExecuteNonQuery();
            KetNoiCoSoDuLieu.DongKetNoi();

        }
    }
}

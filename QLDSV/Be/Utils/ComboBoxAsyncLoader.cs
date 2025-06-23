using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QLDSV.Be.Utils
{
    internal static class ComboBoxAsyncLoader
    {
        public static async Task<DataTable> GetNienKhoaTheoKhoaAsync(string maKhoa)
        {
            string where = "MAKHOA = @makhoa";
            return await Task.Run(() =>
                DbHandler.GetDistinctValues("NIENKHOA", "LOPTINCHI", where, true, new SqlParameter("@makhoa", maKhoa)));
        }

        public static async Task<DataTable> GetHockyTheoNienKhoaAsync(string nienKhoa)
        {
            string where = "NIENKHOA = @nk";
            return await Task.Run(() =>
                DbHandler.GetDistinctValues("HOCKY", "LOPTINCHI", where, true, new SqlParameter("@nk", nienKhoa)));
        }

        public static async Task<DataTable> GetMonTheoHocKyAsync(string nienKhoa, int hocKy)
        {
            string where = "NIENKHOA = @nk AND HOCKY = @hk";
            return await Task.Run(() =>
                DbHandler.GetDistinctValues("MAMH", "LOPTINCHI", where, true,
                    new SqlParameter("@nk", nienKhoa),
                    new SqlParameter("@hk", hocKy)));
        }

        public static async Task<DataTable> GetNhomTheoMonAsync(string nienKhoa, int hocKy, string mamh)
        {
            string where = "NIENKHOA = @nk AND HOCKY = @hk AND MAMH = @mamh";
            return await Task.Run(() =>
                DbHandler.GetDistinctValues("NHOM", "LOPTINCHI", where, false, new SqlParameter("@nk", nienKhoa), new SqlParameter("@hk", hocKy), new SqlParameter("@mamh", mamh)));
        }
    }
}

using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.DAO
{
    public class ShowTimeDAO
    {
        public static DataTable GetAllShowTime (ref string error)
        {
            string query = "select * from dbo.func_getShowtimes";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static DataTable SearchByNameRoom(ref string error)
        {
            string query = "select * from dbo.func_searchShowtimes";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static int Insert(ShowTime showTime, ref string error)
        {
            string query = "exec proc_addShowtimes @Gio, @Ngay, @TrangThai, @MaPhim, @MaPhong";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { 
                showTime.Time, showTime.Day, showTime.Status, showTime.IdFilm, showTime.IdRoom 
            });
        }
        public static int Update(ShowTime showTime, ref string error)
        {
            string query = "exec proc_updateShowtimes @MaSuatChieu, @Gio, @Ngay, @TrangThai, @MaPhim, @MaPhong";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { 
                showTime.Id, showTime.Time, showTime.Day, showTime.Status, showTime.IdFilm, showTime.IdRoom 
            });
        }
        public static int Delete(ShowTime showTime, ref string error)
        {
            string query = "exec proc_deleteShowtimes @MaSuatChieu";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { showTime.Id });
        }
    }
}

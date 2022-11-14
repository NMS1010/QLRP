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
        public static DataTable GetAllShowTime(ref string error)
        {
            string query = "select * from dbo.func_getShowtimes()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchShowtimes( @key )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }

        public static int Insert(ShowTime showTime, ref string error)
        {
            string query = "exec proc_addShowtimes @Gio , @Ngay , @TrangThai , @MaPhim , @MaPhong";
            int count = DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                showTime.Time, showTime.Day, showTime.Status, showTime.IdFilm, showTime.IdRoom
            });

            return count;
        }

        public static int Update(ShowTime showTime, ref string error)
        {
            string query = "exec proc_updateShowtimes @MaSuatChieu , @Gio , @Ngay , @TrangThai , @MaPhim , @MaPhong";
            int count = DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                showTime.Id, showTime.Time, showTime.Day, showTime.Status, showTime.IdFilm, showTime.IdRoom
            });
            if (count == 0)
                return count;
            count = TicketDAO.UpdateTicketPrice(showTime.Id, showTime.IdRoom, ref error);

            return count;
        }

        public static int Delete(int showTimeId, ref string error)
        {
            string query = "exec proc_deleteShowtimes @MaSuatChieu";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { showTimeId });
        }

        public static DataTable GetShowTimeByMovie(int movieId, string date, ref string error)
        {
            string query = "select * from dbo.func_getShowtimesByFilm( @movieId , @date )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { movieId, date });
        }

        public static DataTable GetShowTimeById(int showTimeId, ref string error)
        {
            string query = "select * from dbo.func_getShowtimesById( @showTimeId )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { showTimeId });
        }
    }
}
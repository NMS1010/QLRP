using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class MovieDAO
    {
        public static int Insert(Movie movie, ref string error)
        {
            string query = "exec proc_addFilm @ThoiLuong , @TenPhim , @LuaTuoi , @NgayKhoiChieu , @NgayKetThuc , @DaoDienChinh";
            int count = DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { movie.Time, movie.MovieName, movie.AgeRange, movie.StartDate, movie.EndDate, movie.MainDirector });
            if (!string.IsNullOrEmpty(error)) return 0;
            DataTable dt = DataProvider.ExecuteQuery("select * from dbo.func_getFilmByName( @name )", ref error,
                new object[] { movie.MovieName });
            if (dt == null || dt.Rows.Count == 0) return 0;
            int movieId = (int)dt.Rows[0]["MaPhim"];
            foreach (int categoryId in movie.CategoryIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addFilmCategory @MaPhim , @MaLoai", ref error,
                new object[] { movieId, categoryId });
                if (!string.IsNullOrEmpty(error)) return 0;
            }
            foreach (int actorId in movie.ActorIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addFilmActor @MaPhim , @MaDienVien", ref error,
                new object[] { movieId, actorId });
                if (!string.IsNullOrEmpty(error)) return 0;
            }
            return count;
        }

        public static int Update(Movie movie, ref string error)
        {
            string query = "exec proc_updateFilm @MaPhim , @ThoiLuong , @TenPhim , @LuaTuoi , @NgayKhoiChieu , @NgayKetThuc , @DaoDienChinh";
            int count = DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { movie.MovieId, movie.Time, movie.MovieName, movie.AgeRange, movie.StartDate, movie.EndDate, movie.MainDirector });
            if (!string.IsNullOrEmpty(error)) return 0;
            count = DataProvider.ExecuteNonQuery("exec proc_deleteFilmActorbyFilmId @MaPhim", ref error,
                new object[] { movie.MovieId });
            if (!string.IsNullOrEmpty(error)) return 0;
            count = DataProvider.ExecuteNonQuery("exec proc_deleteFilmCategorybyFilmId @MaPhim", ref error,
                new object[] { movie.MovieId });
            if (!string.IsNullOrEmpty(error)) return 0;
            foreach (int categoryId in movie.CategoryIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addFilmCategory @MaPhim , @MaLoai", ref error,
                new object[] { movie.MovieId, categoryId });
                if (!string.IsNullOrEmpty(error)) return 0;
            }
            foreach (int actorId in movie.ActorIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addFilmActor @MaPhim , @MaDienVien", ref error,
                new object[] { movie.MovieId, actorId });
                if (!string.IsNullOrEmpty(error)) return 0;
            }
            return count;
        }

        public static int Delete(int movieId, ref string error)
        {
            string query = "exec proc_deleteFilm @MaPhim";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { movieId });
        }

        public static DataTable GetAllMovie(ref string error)
        {
            string query = "select * from dbo.func_getAllFilm()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchFilm( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }

        public static DataTable GetMovieByDate(string date, ref string error)
        {
            string query = "select * from dbo.func_getFilmByDate( @date )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { date });
        }

        public static DataTable GetCategoryByFilmId(int filmId, ref string error)
        {
            string query = "select * from dbo.func_getCategoryIdByFilmId( @filmId )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { filmId });
        }

        public static DataTable GetActorByFilmId(int filmId, ref string error)
        {
            string query = "select * from dbo.func_getActorIdByFilmId( @filmId )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { filmId });
        }
    }
}
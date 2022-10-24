using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class RoomDAO
    {
        public static DataTable GetAllRoom(ref string error)
        {
            string query = "select * from dbo.func_getCinemaRoom()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchRoomByName( @key )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }

        public static int Insert(Room room, ref string error)
        {
            string query = "exec proc_addCinemaRoom @TenPhong , @SoCot , @SoHang , @TongSoGhe , @TrangThai , @MaMay";
            int count = DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                room.Name, room.Col, room.Row, room.Col * room.Row, room.Status, room.IdProjector
            });
            if (count == 0) return 0;
            DataTable dt = DataProvider.ExecuteQuery("select * from dbo.func_getRoomByName( @TenPhong )", ref error,
                new object[] { room.Name });
            if (dt == null || dt.Rows.Count == 0) return 0;
            int roomId = (int)dt.Rows[0]["MaPhong"];
            room.Id = roomId;
            foreach (int chairId in room.SeatIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addCinemaRoomChair @MaPhong , @MaGhe , @SoLuong", ref error,
                new object[] { roomId, chairId, room.TotalSeat });
                if (count == 0) return 0;
            }
            return count;
        }

        public static int Update(Room room, ref string error)
        {
            string query = "exec proc_updateCinemaRoom @MaPhong , @TenPhong , @SoCot , @SoHang , @TrangThai , @MaMay";
            int count = DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                room.Id, room.Name, room.Col, room.Row, room.Status, room.IdProjector
            });
            if (count == 0) return 0;
            count = DataProvider.ExecuteNonQuery("exec proc_deleteCinemaRoomChairByRoomId @MaPhong", ref error,
                new object[] { room.Id });
            if (!string.IsNullOrEmpty(error)) return 0;
            foreach (int chairId in room.SeatIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addCinemaRoomChair @MaPhong , @MaGhe , @SoLuong", ref error,
                new object[] { room.Id, chairId, room.TotalSeat });
                if (count == 0) return 0;
            }
            return count;
        }

        public static int Delete(int roomId, ref string error)
        {
            string query = "exec proc_deleteCinemaRoom @MaPhong";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { roomId });
        }

        public static DataTable GetTypeChairIdByRoomId(int roomId, ref string error)
        {
            string query = "select * from dbo.func_getTypeChairIdByRoomId( @MaPhong )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { roomId });
        }

        public static DataTable GetRoomByRoomId(int roomId, ref string error)
        {
            string query = "select * from dbo.func_getRoomByRoomId( @MaPhong )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { roomId });
        }

        public static DataTable GetSeatPriceByRoomId(int roomId, ref string error)
        {
            string query = "select * from dbo.func_getSeatPriceByRoomId( @MaPhong )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { roomId });
        }

        public static DataTable GetProjectorPriceByRoomId(int roomId, ref string error)
        {
            string query = "select * from dbo.func_getProjectorPriceByRoomId( @MaPhong )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { roomId });
        }
    }
}
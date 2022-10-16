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
            string query = "select * from dbo.func_getCinemaRoom";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static DataTable SearchByName(ref string error)
        {
            string query = "select * from dbo.func_searchRoomByName";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static int Insert(Room room, ref string error)
        {
            string query = "exec proc_addCinemaRoom @TenPhong, @SoCot, @SoHang, @TrangThai, @MaMay";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                room.Name, room.Col, room.Row, room.Status, room.IdProjector
            });
        }
        public static int Update(Room room, ref string error)
        {
            string query = "exec proc_updateCinemaRoom @MaPhong, @TenPhong, @SoCot, @SoHang, @TrangThai, @MaMay";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                room.Id, room.Name, room.Col, room.Row, room.Status, room.IdProjector
            });
        }
        public static int Delete(Room room, ref string error)
        {
            string query = "exec proc_deleteCinemaRoom @MaPhong";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { room.Id });
        }
    }
}

using QuanLyRapPhim.Admin.DataUC;
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
    public class TicketDAO
    {
        public static DataTable GetAllTicketByShowTimeId(int showtimeId, ref string error)
        {
            string query = "select * from dbo.func_getTicketByShowTimeId( @MaSC )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { showtimeId });
        }

        public static int Insert(Ticket ticket, ref string error)
        {
            string query = "exec proc_addTicket  @viTriGhe , @MaSuatChieu , @TongGiaVe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                ticket.Seat, ticket.IdShowTime,  ticket.TotalPrice
            });
        }

        public static int UpdateStatus(Ticket ticket, ref string error)
        {
            string query = "exec proc_buyTicket @MaKH , @MaVe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { ticket.IdCustomer, ticket.Id });
        }

        public static DataTable GetBoughtTicket(int showTimeId, ref string error)
        {
            string query = "select * from dbo.func_getBoughtTicket( @MaSC )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { showTimeId });
        }

        public static int UpdateTicketPrice(int showTimeId, int roomId, ref string error)
        {
            DataTable seatPriceDT = RoomDAO.GetSeatPriceByRoomId(roomId, ref error);
            DataTable projectorPriceDT = RoomDAO.GetProjectorPriceByRoomId(roomId, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                return 0;
            }
            if (seatPriceDT.Rows.Count == 0 || projectorPriceDT.Rows.Count == 0)
            {
                error = "Có lỗi xảy ra!!!";
                return 0;
            }
            decimal seatPrice = (decimal)seatPriceDT.Rows[0]["GiaGhe"];
            decimal projectorPrice = (decimal)projectorPriceDT.Rows[0]["Gia"];
            string query = "exec proc_updateTicketPrice @MaSuatChieu , @TongGiaVe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { showTimeId, seatPrice + projectorPrice });
        }

        public static DataTable GetTicketIdBySeatName(string seatName, int showTimeId, ref string error)
        {
            string query = "select * from dbo.func_getTicketIdBySeatName( @seatName , @showTimeId )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { seatName, showTimeId });
        }

        public static bool GenerateTicket(int showTimeID, int roomId, ref string error)
        {
            DataTable roomDt = RoomDAO.GetRoomByRoomId(roomId, ref error);
            DataTable seatPriceDT = RoomDAO.GetSeatPriceByRoomId(roomId, ref error);
            DataTable projectorPriceDT = RoomDAO.GetProjectorPriceByRoomId(roomId, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                return false;
            }
            if (roomDt.Rows.Count == 0 || seatPriceDT.Rows.Count == 0 || projectorPriceDT.Rows.Count == 0)
            {
                error = "Có lỗi xảy ra!!!";
                return false;
            }
            int numberRows = int.TryParse(roomDt.Rows[0]["SoHang"].ToString(), out int row) ? row : -1;
            int numberChairPerRow = int.TryParse(roomDt.Rows[0]["SoCot"].ToString(), out int col) ? col : -1;

            decimal seatPrice = (decimal)seatPriceDT.Rows[0]["GiaGhe"];
            decimal projectorPrice = (decimal)projectorPriceDT.Rows[0]["Gia"];
            if (numberRows == -1 || numberChairPerRow == -1)
                return false;
            string strSequence = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int count = 1;
            for (int i = 0; i < numberRows; i++)
            {
                for (int j = 0; j < numberChairPerRow; j++)
                {
                    Ticket ticket = new Ticket()
                    {
                        Seat = strSequence[i] + j.ToString(),
                        IdShowTime = showTimeID,
                        TotalPrice = seatPrice + projectorPrice
                    };
                    count = Insert(ticket, ref error);
                    if (count == 0)
                        return false;
                }
            }
            return true;
        }
    }
}
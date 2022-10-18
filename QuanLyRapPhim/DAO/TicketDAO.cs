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
        public static DataTable GetAllTicketBoughted(ref string error)
        {
            string query = "select * from dbo.func_getBoughtTicket";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static int Insert(Ticket ticket, ref string error)
        {
            string query = "exec proc_addTicket  @viTriGhe, @MaSuatChieu , @TongGiaVe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { 
                ticket.Seat, ticket.IdShowTime,  ticket.TotalPrice
            }); 
        } 
        public static int UpdateStatus(Ticket ticket, ref string error)
        {
            string query = "exec proc_buyTicket @MaKH , @MaVe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { ticket.IdCustomer, ticket.Id });
        }
    }
}
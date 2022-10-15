using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Seat { get; set; }
        public int Status { get; set; }
        public decimal TotalPrice { get; set; }
        public int IdShowTime { get; set; }
        public int IdCustomer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalSeat { get; set; }
        public int Col { get; set; }
        public int Row { get; set; }
        public int Status { get; set; }
        public int IdProjector{ get; set; }
    }
}

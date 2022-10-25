using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Movie
    {
        public int MovieId { get; set; }
        public decimal Time { get; set; }
        public string MovieName { get; set; }
        public int AgeRange { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string MainDirector { get; set; }

        public List<int> CategoryIds { get; set; } = new List<int>();
        public List<int> ActorIds { get; set; } = new List<int>();
    }
}
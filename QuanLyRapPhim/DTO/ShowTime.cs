﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class ShowTime
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Day { get; set; }
        public int Status { get; set; }
        public int IdFilm { get; set; }
        public int IdRoom { get; set; }
    }
}
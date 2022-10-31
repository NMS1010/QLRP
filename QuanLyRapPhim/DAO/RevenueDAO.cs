using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class RevenueDAO
    {
        public static DataTable GetRevenue(string movieName, string startDate, string endDate, ref string error)
        {
            string query = "select * from dbo.func_getRevenueByFilm( @filmName , @startDate , @endDate )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { movieName, startDate, endDate });
        }
    }
}
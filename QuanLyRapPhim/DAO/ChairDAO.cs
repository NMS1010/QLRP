using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class ChairDAO
    {
        public static DataTable GetAllChair(ref string error)
        {
            string query = "select * from dbo.func_getChair()";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static int Update(Chair chair, ref string error)
        {
            string query = "exec proc_updateChair @MaGhe , @GiaGhe , @LoaiGhe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                chair.ChairId, chair.Price, chair.Type
            });
        }
    }
}
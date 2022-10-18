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
            string query = "select * from dbo.func_getChair";
            return DataProvider.ExecuteQuery(query, ref error);
        }
        public static int Insert(Chair chair, ref string error)
        {
            string query = "exec proc_addChair @GiaGhe , @LoaiGhe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                chair.Price, chair.Type
            });
        }
        public static int Update(Chair chair, ref string error)
        {
            string query = "exec proc_updateChair @MaGhe , @GiaGhe , @LoaiGhe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                chair.Id, chair.Price, chair.Type
            });
        }
        public static int Delete(Chair chair, ref string error)
        {
            string query = "exec proc_deleteChair @MaGhe";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { chair.Id });
        }
    }
}
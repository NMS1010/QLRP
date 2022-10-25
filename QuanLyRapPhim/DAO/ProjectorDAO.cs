using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class ProjectorDAO
    {
        public static DataTable GetAllProjector(ref string error)
        {
            string query = "select * from dbo.func_getProjector()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static int Insert(Projector projector, ref string error)
        {
            string query = "exec proc_addProjector @LoaiMay , @Gia";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                projector.Type, projector.Price
            });
        }

        public static int Update(Projector projector, ref string error)
        {
            string query = "exec proc_updateProjector @MaMay , @LoaiMay , @Gia";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] {
                projector.Id, projector.Type, projector.Price
            });
        }

        public static int Delete(int projectorId, ref string error)
        {
            string query = "exec proc_deleteProjector @MaMay";
            return DataProvider.ExecuteNonQuery(query, ref error, new object[] { projectorId });
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchAllProjector( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
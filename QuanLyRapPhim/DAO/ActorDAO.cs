using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class ActorDAO
    {
        public static int Insert(Actor actor, ref string error)
        {
            string query = "exec proc_add_Actor @TenDienVien";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { actor.ActorName });
        }

        public static int Update(Actor actor, ref string error)
        {
            string query = "exec proc_update_Actor @MaDienVien , @TenDienVien";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { actor.ActorId, actor.ActorName });
        }

        public static int Delete(int actorId, ref string error)
        {
            string query = "exec proc_delete_Actor @MaDienVien";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { actorId });
        }

        public static DataTable GetAllActor(ref string error)
        {
            string query = "select * from dbo.func_getActor()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchActor( @key )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
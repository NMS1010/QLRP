using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class PermissionDAO
    {
        public static int Insert(Permission permission, ref string error)
        {
            string query = "exec proc_addPermission @TenQuyen";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { permission.PermissionName });
        }

        public static int Update(Permission permission, ref string error)
        {
            string query = "exec proc_updatePermission @MaQuyen , @TenQuyen";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { permission.PermissionId, permission.PermissionName });
        }

        public static int Delete(int permissionId, ref string error)
        {
            string query = "exec proc_deletePermission @MaQuyen";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { permissionId });
        }

        public static DataTable GetAllPermission(ref string error)
        {
            string query = "select * from dbo.func_getAllPermission()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchPermission( @TenQuyen )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
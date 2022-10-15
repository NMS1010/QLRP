using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class RoleDAO
    {
        public static int Insert(Role role, ref string error)
        {
            string query = "exec proc_addRole @TenVaiTro";
            int count = DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { role.RoleName });
            if (count == 0) return 0;
            foreach (int permissionId in role.PermissionIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addRolePermission @MaVaiTro @MaQuyen", ref error,
                new object[] { role.RoleId, permissionId });
                if (count == 0) return 0;
            }
            return count;
        }

        public static int Update(Role role, ref string error)
        {
            string query = "exec proc_updateRole @MaVaiTro , @TenVaiTro";
            int count = DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { role.RoleId, role.RoleName });
            if (count == 0) return 0;
            count = DataProvider.ExecuteNonQuery("exec proc_deleteRolePermissionbyRoleId @MaVaiTro", ref error,
                new object[] { role.RoleId });
            if (count == 0) return 0;
            foreach (int permissionId in role.PermissionIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addRolePermission @MaVaiTro @MaQuyen", ref error,
                new object[] { role.RoleId, permissionId });
                if (count == 0) return 0;
            }
            return count;
        }

        public static int Delete(int roleId, ref string error)
        {
            string query = "exec proc_deleteRole @MaVaiTro";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { roleId });
        }

        public static DataTable GetAllRole(ref string error)
        {
            string query = "select * from dbo.func_getAllRole()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchRole( @TenVaiTro )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
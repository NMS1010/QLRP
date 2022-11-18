using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class UserDAO
    {
        public static int Insert(User user, ref string error)
        {
            string query = "exec proc_addUser @TenND , @GioiTinh , @NgaySinh , @SDT , @CCCD , @Email , @TenTaiKhoan , @MatKhau , @Luong";
            int count = DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { user.FullName, user.Gender, user.Dob, user.Phone, user.CCCD, user.Email, user.UserName, user.Password, user.Salary });
            if (count == 0) return 0;
            DataTable dt = DataProvider.ExecuteQuery("select * from dbo.func_getUserByUserName( @username )", ref error,
                new object[] { user.UserName });
            if (dt == null || dt.Rows.Count == 0) return 0;
            int userId = (int)dt.Rows[0]["MaND"];
            user.UserId = userId;
            foreach (int roleId in user.RoleIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addUserRole @MaND , @MaVaiTro", ref error,
                new object[] { userId, roleId });
                if (count == 0) return 0;
            }
            return count;
        }

        public static int Update(User user, ref string error)
        {
            string query = "exec proc_updateUser @MaND , @TenND , @GioiTinh , @NgaySinh , @SDT , @CCCD , @Email , @TenTaiKhoan , @MatKhau , @Luong";
            int count = DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { user.UserId, user.FullName, user.Gender, user.Dob, user.Phone, user.CCCD, user.Email, user.UserName, user.Password, user.Salary });
            if (count == 0) return 0;
            count = DataProvider.ExecuteNonQuery("exec proc_deleteUserRolebyUserId @MaND", ref error,
                new object[] { user.UserId });
            if (!string.IsNullOrEmpty(error)) return 0;
            foreach (int roleId in user.RoleIds)
            {
                count = DataProvider.ExecuteNonQuery("exec proc_addUserRole @MaND , @MaVaiTro", ref error,
                new object[] { user.UserId, roleId });
                if (count == 0) return 0;
            }
            return count;
        }

        public static int Delete(int userId, ref string error)
        {
            string query = "exec proc_deleteUser @MaND";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { userId });
        }

        public static int Login(string username, string password, ref string error)
        {
            string query = "select dbo.func_Login( @username , @password )";
            object res = DataProvider.ExecuteScalar(query, ref error, new object[] { username, password });
            return (int)res;
        }

        public static DataTable GetAllUser(ref string error)
        {
            string query = "select * from dbo.func_getAllUser()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchUser( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }

        public static DataTable GetRoleIdByUserId(int userId, ref string error)
        {
            string query = "select * from dbo.func_getRoleIdByUserId( @userId )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { userId });
        }

        public static DataTable GetRoleNameByUsername(string username, ref string error)
        {
            string query = "select * from dbo.func_getRoleNameByUsername( @username )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { username });
        }
    }
}
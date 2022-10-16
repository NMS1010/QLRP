using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class CustomerDAO
    {
        public static int Insert(Customer customer, ref string error)
        {
            string query = "exec proc_addCustomer @Ten, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @MaLoaiKH, @Email";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { customer.Name, customer.Sex, customer.Dob, customer.Address, customer.PhoneNumber, customer.TypeCustomerId, customer.Email });
        }

        public static int Update(Customer customer, ref string error)
        {
            string query = "exec proc_updateCustomer @MaKH, @Ten, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @MaLoaiKH, @Email";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { customer.CustomerId, customer.Name, customer.Sex, customer.Dob, customer.Address, customer.PhoneNumber, customer.TypeCustomerId, customer.Email });
        }

        public static int Delete(int CustomerId, ref string error)
        {
            string query = "exec proc_deleteCustomer @MaKH";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { CustomerId });
        }

        public static DataTable GetAllCustomer(ref string error)
        {
            string query = "select * from dbo.func_getAllCustomer()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchAllCustomer( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
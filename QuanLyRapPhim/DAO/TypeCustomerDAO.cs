using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class TypeCustomerDAO
    {
        public static int Insert(TypeCustomer typeCustomer, ref string error)
        {
            string query = "exec proc_addCustomerType @TenLoaiKH";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { typeCustomer.Name });
        }

        public static int Update(TypeCustomer typeCustomer, ref string error)
        {
            string query = "exec proc_updateCustomerType @MaLoaiKH, @TenLoaiKH";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { typeCustomer.TypeCustomerId, typeCustomer.Name});
        }

        public static int Delete(int TypeCustomerId, ref string error)
        {
            string query = "exec proc_deleteCustomerType @MaLoaiKH";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { TypeCustomerId });
        }

        public static DataTable GetAllTypeCustomer(ref string error)
        {
            string query = "select * from dbo.func_getAllCustomerType()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchAllCustomerType( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
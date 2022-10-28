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
            string query = "exec proc_addTypeCustomer @TenLoaiKH , @GiamGia";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { typeCustomer.Name, typeCustomer.Price });
        }

        public static int Update(TypeCustomer typeCustomer, ref string error)
        {
            string query = "exec proc_updateTypeCustomer @TenLoaiKH , @MaLoaiKH, @GiamGia";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { typeCustomer.Name, typeCustomer.TypeCustomerId, typeCustomer.Price });
        }

        public static int Delete(int TypeCustomerId, ref string error)
        {
            string query = "exec proc_deleteTypeCustomer @MaLoaiKH";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { TypeCustomerId });
        }

        public static DataTable GetAllTypeCustomer(ref string error)
        {
            string query = "select * from dbo.func_getAllTypeCustomer()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchAllTypeCustomer( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class CategoryDAO
    {
        public static int Insert(Category category, ref string error)
        {
            string query = "exec proc_addCategory @TenLoai";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { category.CategoryName });
        }

        public static int Update(Category category, ref string error)
        {
            string query = "exec proc_updateCategory @MaLoai , @TenLoai";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { category.CategoryId, category.CategoryName });
        }

        public static int Delete(int categoryId, ref string error)
        {
            string query = "exec proc_deleteCategory @MaLoai";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { categoryId });
        }

        public static DataTable GetAllCategory(ref string error)
        {
            string query = "select * from dbo.func_getAllCategory()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchCategory( @TenLoai )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
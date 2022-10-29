using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class BillDAO
    {
        public static int Insert(Bill bill, ref string error)
        {
            string query = "exec proc_addBill @MaKH , @MaKM , @GioXuat , @NgayXuat , @TongChiPhi";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { bill.CustomerId, bill.PromotionId, bill.InvoiceTime, bill.InvoiceDate, bill.SumCost });
        }

        public static DataTable GetAllBill(ref string error)
        {
            string query = "select * from dbo.func_getAllBill()";
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchBill( @key )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
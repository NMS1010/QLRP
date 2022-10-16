using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class PromotionDAO
    {
        public static int Insert(Promotion promotion, ref string error)
        {
            string query = "exec  proc_addDiscount @TenKM, @GiaTriKM";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { promotion.Name, promotion.ValueOfPromotion });
        }

        public static int Update(Promotion promotion, ref string error)
        {
            string query = "exec proc_updateDiscount @MaKM, @TenKM, @GiaTriKM";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { promotion.PromotionId, promotion.Name, promotion.ValueOfPromotion });
        }

        public static int Delete(int PromotionId, ref string error)
        {
            string query = "exec proc_deleteDiscount @MaKM";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { PromotionId });
        }

        public static DataTable GetAllPromotion(ref string error)
        {
            string query = "select * from dbo.func_getAllDiscount();
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchAllDiscount( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
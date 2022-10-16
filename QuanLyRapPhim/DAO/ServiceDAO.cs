using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class ServiceDAO
    {
        public static int Insert(Service service, ref string error)
        {
            string query = "exec proc_addService @TenDichVu, @Gia";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { service.Name, service.Price });
        }

        public static int Update(Service service, ref string error)
        {
            string query = "exec proc_updateService @MaDichVu, @TenDichVu, @Gia";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { service.ServiceId, service.Name, service.Price});
        }

        public static int Delete(int ServiceId, ref string error)
        {
            string query = "exec proc_deleteService @MaDichVu";
            return DataProvider.ExecuteNonQuery(query, ref error,
                new object[] { ServiceId });
        }

        public static DataTable GetAllService(ref string error)
        {
            string query = "select * from dbo.func_getAllService();
            return DataProvider.ExecuteQuery(query, ref error);
        }

        public static DataTable Search(string keyword, ref string error)
        {
            string query = "select * from dbo.func_searchAllService( @keyword )";
            return DataProvider.ExecuteQuery(query, ref error, new object[] { keyword });
        }
    }
}
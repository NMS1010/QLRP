using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class DataProvider
    {
        public static string ServerName;
        public static string DataBaseName;
        public static string UserName;
        public static string Password;
        public static string ConnectionString;

        public static DataTable ExecuteQuery(string query, ref string error, object[] parameter = null)
        {
            ConnectionString = $@"Data Source={ServerName};Initial Catalog={DataBaseName};User Id={UserName};Password={Password};";
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');

                        int i = 0;

                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(data);

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return data;
        }

        public static int ExecuteNonQuery(string query, ref string error, object[] parameter = null)
        {
            ConnectionString = $@"Data Source={ServerName};Initial Catalog={DataBaseName};User Id={UserName};Password={Password};";
            int data = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');

                        int i = 0;

                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return data;
        }

        public static object ExecuteScalar(string query, ref string error, object[] parameter = null)
        {
            ConnectionString = $@"Data Source={ServerName};Initial Catalog={DataBaseName};User Id={UserName};Password={Password};";
            object data = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');

                        int i = 0;

                        foreach (string item in listPara)
                        {
                            if (item.Contains('@') && !item.Contains("@@"))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = cmd.ExecuteScalar();

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return data;
        }
    }
}
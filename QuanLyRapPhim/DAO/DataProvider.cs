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
        public static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLRP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static DataTable ExecuteQuery(string query, ref string error, object[] parameter = null)
        {
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
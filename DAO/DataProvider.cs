using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLHT;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int k = 0;
                    foreach (string i in listPara)
                        if (i.Contains('@'))
                        {
                            command.Parameters.AddWithValue(i, param[k]);
                            k++;
                        }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int k = 0;
                    foreach (string i in listPara)
                        if (i.Contains('@'))
                        {
                            command.Parameters.AddWithValue(i, param[k]);
                            k++;
                        }
                }

                data = command.ExecuteNonQuery();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    string[] listPara = query.Split(' ');
                    int k = 0;
                    foreach (string i in listPara)
                        if (i.Contains('@'))
                        {
                            command.Parameters.AddWithValue(i, param[k]);
                            k++;
                        }
                }

                data = command.ExecuteScalar();
            }
            return data;
        }
    }
}

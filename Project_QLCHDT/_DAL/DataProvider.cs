using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace _DAL
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = "SERVER= remotemysql.com; PORT = 3306; DATABASE= nT9AKE4dyx; UID= nT9AKE4dyx; PASSWORD= MvroSKtwKp; connect timeout = 100000000; oldguids=true";

        public MySqlConnection connection()
        {
            MySqlConnection connect = new MySqlConnection(connectionSTR);
            return connect;
        }

        public System.Data.DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            MySqlCommand command = new MySqlCommand(query, connection());
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(data);

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            MySqlConnection connector = connection();
            MySqlCommand command = new MySqlCommand(query, connector);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            connector.Open();
            data = command.ExecuteNonQuery();

            return data;
        }

        public bool ExecuteReader(string query, object[] parameter = null)
        {
            MySqlConnection connector = connection();
            MySqlCommand command = new MySqlCommand(query, connector);
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            connector.Open();
            MySqlDataReader reader_data = command.ExecuteReader();
            return reader_data.Read();
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            MySqlCommand command = new MySqlCommand(query, connection());

            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteScalar();

            return data;
        }
    }
}

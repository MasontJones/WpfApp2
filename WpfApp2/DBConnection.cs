﻿using MySql.Data;
using MySql.Data.MySqlClient;
using System;

namespace Data
{
     class DBConnection
    {
        private DBConnection()
        {
        }

        public string Server { get; set; }
        public string databaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, databaseName, UserName, Password);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
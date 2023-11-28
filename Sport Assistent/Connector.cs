using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Sport_Assistent
{
    class Connector: ApplicationSettingsBase
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter=new MySqlDataAdapter();
        private MySqlCommand command;
        public Connector(string connectstr) { connection = new MySqlConnection(connectstr); }
        public DataTable ExecuteCommand(string comand)
        {
            command = new MySqlCommand(comand,connection);
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void OpenConnection() { connection.Open(); }
        public void CloseConnection() { connection.Close(); }

        public MySqlConnection GetConnection() { return connection; }
    }
}

﻿using Npgsql;

namespace PercobaanApi1.Helpers
{
    public class sqlDBHelper
    {
        private NpgsqlConnection connection;
        private string __constr;

        public sqlDBHelper(string pCOnstr)
        {
            __constr = pCOnstr;
            connection = new NpgsqlConnection();
            connection.ConnectionString = __constr;
        }

        public NpgsqlCommand getNpgsqlCommand(string query)
        {
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            return cmd;
        }

        public void closeConnection()
        {
            connection.Close();
        }

    }
}

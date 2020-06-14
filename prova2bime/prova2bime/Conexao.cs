using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prova2bime
{
    public class Conexao
    {
        private static string server = "localhost";
        private static string database = "cadastro";
        private static string user = "root";
        private static string password = "jorelbrabo123";

        private static string conectionString = $@"Server={server}; Database={database};Uid={user};Pwd={password};SslMode=None;CharSet = utf8;";

        public static MySqlConnection Connection = new MySqlConnection(conectionString);

        public static void Conectar()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void Desconectar()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }

        }
    }
}
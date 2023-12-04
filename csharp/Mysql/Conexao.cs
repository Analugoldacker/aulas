using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.Utlis
{
    public class Conexao
    {
        public static MySqlConnection conectar()
        {
            string connString = "Server=localhost;Database=aula;Uid=root;Pwd=admin";
            MySqlConnection connection = new MySqlConnection(connString);
            return connection;
        }
    }
}

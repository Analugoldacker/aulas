using MySql.Data.MySqlClient;
using MySql.Entidades;
using MySql.Utlis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.Dao
{
    public class DaoContatoMysql
    {
        public bool salvar(Contato contato)
        {
            /* string connString = "Server=localhost;Database=agenda;Uid=root;Pwd=admin";
             MySqlConnection connection = new MySqlConnection(connString);
             MySqlCommand command = connection.CreateCommand();
            */
            MySqlConnection con = Conexao.conectar();
            MySqlCommand command = con.CreateCommand();
            try
            {
                con.Open();
                command.CommandText = "insert into tb_contatos(nome, email, fone)values(@nome,@email,@fone)";
                command.Parameters.Add("nome", MySqlDbType.VarString).Value = contato.Nome;
                command.Parameters.Add("email", MySqlDbType.VarString).Value = contato.Email;
                command.Parameters.Add("fone", MySqlDbType.VarString).Value = contato.Fone;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return true;
        }

        public List<Contato> consultar()
        {
            List<Contato> contatos = new();

            /* string connString = "Server=localhost;Database=agenda;Uid=root;Pwd=admin";
             MySqlConnection connection = new MySqlConnection(connString);
             MySqlCommand command = connection.CreateCommand();*/

            /*pega conexão da classe*/
            MySqlConnection con = Conexao.conectar();
            MySqlCommand command = con.CreateCommand();
            try
            {
                con.Open();
                command.CommandText = "select * from tb_contatos";
                MySqlDataReader dr = command.ExecuteReader();
                //List<Contato> contatos = new List<Contato>();

                while (dr.Read())
                {
                    Contato ct = new Contato();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Email = Convert.ToString(dr["email"]);
                    ct.Fone = Convert.ToString(dr["fone"]);
                    contatos.Add(ct);
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return contatos;
        }
    }
}

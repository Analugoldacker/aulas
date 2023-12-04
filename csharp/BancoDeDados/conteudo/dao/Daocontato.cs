using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttBDD.entidade;

namespace AttBDD.DaoContato
{
    public class Daocontato
    {
        public bool salvar(Contato contato)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database/danco de dados*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                
                /*monta comando DML a ser enviado para o database/banco de dados*/
                SqlCommand cn = con.CreateCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_contatos([nome],[email],[telefone])values(@nome,@email,@telefone)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("nome",SqlDbType.VarChar).Value = contato.Nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = contato.Email;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = contato.Telefone;

                /*abrir a conexão*/
                con.Open();
                cn.Connection = con;

                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }
    }
}

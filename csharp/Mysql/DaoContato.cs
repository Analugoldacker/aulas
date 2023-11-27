using Microsoft.Data.SqlClient;
using MySql.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.Dao
{
    public class DaoContato
    {
        
        public bool salvar(Contato contato)
        {
            using(SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_contatos([nome],[email],[fone])values(@nome,@email,@fone)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = contato.Nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = contato.Email;
                cn.Parameters.Add("fone", SqlDbType.VarChar).Value = contato.Fone;

                /*abrir a conexaõ*/

                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }

        public void consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_contatos";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Contato ct = new Contato();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Email = Convert.ToString(dr["email"]);
                    ct.Fone = Convert.ToString(dr["fone"]);
                    Console.WriteLine(ct.ToString());
                }
            }
        }
    }
}

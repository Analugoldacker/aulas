using AttBDD.interfaces;
using AttBDD.Pro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttBDD.dao
{
    public class DaoProduto : ICrud<Produto>
    {
        public bool alterar(string novoproduto, Produto t)
        {
            using (SqlConnection con = new SqlConnection()) 
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "UPDATE [tb_produtos] SET ([Nome],[ValorUnitario]) = (@nome,@vaorUnitario) WHERE id = @id";

                cn.Parameters.AddWithValue("@id", t.Id);
                cn.Parameters.AddWithValue("@nome", t.Nome);
                cn.Parameters.AddWithValue("@valorUnitario", t.ValorUnitario);
                cn.Parameters.AddWithValue("@id", t.Id);

                cn.Connection = con;

                return cn.ExecuteNonQuery() > 0;
            }

        }

        public bool alterar(Produto t)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "UPDATE [tb_categorias] SET [descricao] = @descricao WHERE id = @id";

                /*envia os dados a serem gravados*/
                cn.Parameters.AddWithValue("@valorunitario", t.ValorUnitario);
                cn.Parameters.AddWithValue("@nome", t.Nome);
                cn.Parameters.AddWithValue("@id", t.Id);

                /*abrir a conexaõ*/
                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }

        public Produto consultar(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_produto where Id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = id;
                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                Produto pro = new Produto();
                dr = cn.ExecuteReader();
                if (dr.Read())
                {
                    pro.Id = Convert.ToInt32(dr["Id"]);
                    pro.Nome = Convert.ToString(dr["nome"]);
                    pro.ValorUnitario = Convert.ToString(dr["valorUnitario"]);
                }
                return pro;
            }
        }

        public List<Produto> consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_produtos";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                List<Produto> produtos = new();
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Produto pro = new Produto();
                    pro.Id = Convert.ToInt32(dr["Id"]);
                    pro.Nome = Convert.ToString(dr["Nome"]);
                    pro.ValorUnitario = Convert.ToString(dr["ValorUnitario"]);
                    produtos.Add(pro);
                }
                return produtos;
            }
        }

        public void excluir(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "DELETE FROM [tb_produto] WHERE id = @id";

                cn.Parameters.AddWithValue("@id", id);

                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public bool salvar(Produto t)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_produto([Nome],[ValorUnitario])values(@Nome,@ValorUnitario)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = t.Nome;
                cn.Parameters.Add("valorUnitario", SqlDbType.VarChar).Value = t.ValorUnitario;

                /*abrir a conexaõ*/
                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }
    }
}

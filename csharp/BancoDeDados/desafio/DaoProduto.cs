using AttBDD.interfaces;
using AttBDD.Pro;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttBDD.dao
{
    public class DaoProduto : ICrud<Produto>
    {
        public bool alterar(Produto produto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "UPDATE [tb_categorias] SET [nome] = @nome,[valorunitario] = @valorunitario, WHERE id = @id";

                /*envia os dados a serem gravados*/

                cn.Parameters.AddWithValue("@id", descricao.Id);
                cn.Parameters.AddWithValue("@descricao", categoria.Descricao);
                cn.Parameters.AddWithValue("@descricao", categoria.Descricao);

                /*abrir a conexaõ*/
                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }

        public Categoria consultar(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_categorias where Id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = id;
                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                Categoria cat = new Categoria();
                dr = cn.ExecuteReader();
                if (dr.Read())
                {
                    cat.Id = Convert.ToInt32(dr["Id"]);
                    cat.Descricao = Convert.ToString(dr["descricao"]);
                }
                return cat;
            }
        }
        public List<Categoria> consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_categorias";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                List<Categoria> categorias = new();
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Categoria cat = new Categoria();
                    cat.Id = Convert.ToInt32(dr["Id"]);
                    cat.Descricao = Convert.ToString(dr["descricao"]);
                    categorias.Add(cat);
                }
                return categorias;
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
                cn.CommandText = "DELETE FROM [tb_categorias] WHERE id = @id";

                cn.Parameters.AddWithValue("@id", id);

                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public bool salvar(Categoria t)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_produtos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_categorias([Descricao])values(@descricao)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = t.Descricao;

                /*abrir a conexaõ*/
                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }
    }
}

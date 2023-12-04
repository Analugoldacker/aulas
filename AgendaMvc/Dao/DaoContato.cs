using AgendaMvc.Interface;
using AgendaMvc.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AgendaMvc.Dao
{        
    public class DaoContato : ICrud<Contato>
    {
        public bool alterar(Contato contato)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = AgendaMvc.Dao.DbConexao.stringConexao;
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "update tb_contatos set [nome] = @nome,[email]=@email,[fone]=@fone where [id]=@id";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = contato.Nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = contato.Email;
                cn.Parameters.Add("fone", SqlDbType.VarChar).Value = contato.Telefone;
                cn.Parameters.Add("id", SqlDbType.Int).Value = contato.Id;

                /*abrir a conexaõ*/

                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }

        public Contato consultar(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = AgendaMvc.Dao.DbConexao.stringConexao;
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_contatos where id = @id";
                cn.Parameters.Add("id",SqlDbType.Int).Value = id;
                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                Contato ct = new Contato();
                while (dr.Read())
                {
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Email = Convert.ToString(dr["email"]);
                    ct.Telefone = Convert.ToString(dr["fone"]);
                }
                return ct;
            }
        }

        public List<Contato> consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = AgendaMvc.Dao.DbConexao.stringConexao;
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
                List<Contato> contatos = new List<Contato>();
                while (dr.Read())
                {
                    Contato ct = new Contato();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Email = Convert.ToString(dr["email"]);
                    ct.Telefone = Convert.ToString(dr["fone"]);
                    contatos.Add(ct);
                }
                return contatos;
            }
        }

        public bool salvar(Contato contato)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = AgendaMvc.Dao.DbConexao.stringConexao;
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_contatos([nome],[email],[fone])values(@nome,@email,@fone)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = contato.Nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = contato.Email;
                cn.Parameters.Add("fone", SqlDbType.VarChar).Value = contato.Telefone;

                /*abrir a conexaõ*/

                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }              
        public void excluir(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = DbConexao.stringConexao;
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "DELETE FROM tb_contatos WHERE id = @id";

                cn.Parameters.AddWithValue("@id", id);

                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }
    }    
}
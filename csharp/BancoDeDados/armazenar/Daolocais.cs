using Emplementacao.entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplementacao.dao
{
    public class Daolocais
    {
        public void consultar()
        {
            using (SqlConnection loc = new SqlConnection())
            {
                /*criado conexão com database/danco de dados*/
                loc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                /*monta comando DML a ser enviado para o database/banco de dados*/
                SqlCommand lo = loc.CreateCommand();
                lo.CommandType = CommandType.Text;
                lo.CommandText = "select * from tb_locais";

                /*abrir a conexaõ*/
                lo.Connection = loc;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = lo.ExecuteReader();
                while (dr.Read())
                {
                    Locais lc = new Locais();
                    lc.Id = Convert.ToInt32(dr["id"]);
                    lc.Nome = Convert.ToString(dr["nome"]);
                    lc.Rua = Convert.ToString(dr["rua"]);
                    lc.Numero = Convert.ToString(dr["numero"]);
                    lc.Cidade = Convert.ToString(dr["cidade"]);
                    lc.Uf = Convert.ToString(dr["uf"]);
                    Console.WriteLine(lc.ToString());
                }
            }
        }
    }
}

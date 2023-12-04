using BancoDeDados.entidade;
using BancoDeDados.entidade1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.dao1
{
    public class Daolocais
    {
        public bool Salvar(Locais locais)
        {
            using (SqlConnection loc = new SqlConnection())
            {
                /*criado conexão com database/danco de dados*/
                loc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bancodedados_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                /*monta comando DML a ser enviado para o database/banco de dados*/
                SqlCommand lo = loc.CreateCommand();
                lo.CommandType = CommandType.Text;
                lo.CommandText = "insert into tb_locais ([nome],[rua],[numero],[cidade],[uf])values(@nome,@rua,@numero,@cidade,@uf)";

                /*envia os dados a serem gravados*/
                lo.Parameters.Add("nome", SqlDbType.VarChar).Value = locais.Nome;
                lo.Parameters.Add("rua", SqlDbType.VarChar).Value = locais.Rua;
                lo.Parameters.Add("numero", SqlDbType.VarChar).Value = locais.Numero;
                lo.Parameters.Add("cidade", SqlDbType.VarChar).Value = locais.Cidade;
                lo.Parameters.Add("uf", SqlDbType.VarChar).Value = locais.Uf;
            }
        }

    }
}

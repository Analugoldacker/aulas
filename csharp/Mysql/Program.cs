using MySql.Dao;
using MySql.Entidades;

namespace MySql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mysql();

            Console.ReadLine();
        }
        static void Mysql()
        {
            Contato ct = new Contato(1, "maria", "maria@gmail.com", "(47)9900-1234");

            /* DaoContato daoContato = new DaoContato();
             if (daoContato.salvar(ct))
             {
                Console.WriteLine("Contato salvo com sucesso");
             }
            daoContato.consultar();*/

            DaoContatoMysql daoMysql = new DaoContatoMysql();
            if (daoMysql.salvar(ct))
            {
                Console.WriteLine("Contato salvo com sucesso");
            }

            List<Contato> contatos;
            // DaoContatoMysql daoMysql = new DaoContatoMysql();
            contatos = daoMysql.consultar();

            foreach (Contato contato in contatos)
            {
                Console.WriteLine(contato.ToString());
            }
        }
    }
}
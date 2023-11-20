using Emplementacao.dao;
using Emplementacao.entidade;

namespace Emplementacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArmazenarContato();
            ArmazenarLocais();
            Console.ReadKey();
        }
        static void ArmazenarContato()
        {
            Contato ct = new Contato(1, "maria", "maria@gmail.com", "(47)9900-1234");

            DaoContato daoContato = new DaoContato();
            /* if (daoContato.salvar(ct))
             {
                 Console.WriteLine("Contato salvo com sucesso");
             }*/
            daoContato.consultar();
        }
        static void ArmazenarLocais()
        {
            Locais lc = new Locais(1, "casa", "Carlos Krueger", "309", "Blumenau", "SC");

            Daolocais daolocais = new Daolocais();
            /*if (Daolocais.Salvar(lc))
            {
                Console.WriteLine("Locais salvo comsucesso");
            }*/
            daolocais.consultar();
        }
    }
}
using BancoDeDados.dao1;
using BancoDeDados.DaoContato;
using BancoDeDados.entidade;
using BancoDeDados.entidade1;

namespace BancoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contato();
            local();
            Console.ReadLine();

        }
        static void contato()
        {
            Contato ct = new Contato(1, "Analú", "analu@gmail.com", "(47) 99231-4893");

            Daocontato daoContato = new Daocontato();
            if (daoContato.salvar(ct))
            {
                Console.WriteLine("Contato salvo comsucesso");
            }

        }
        static void local()
        {
            Locais lc = new Locais(1,"casa","Carlos Krueger","309","Blumenau","SC");

            Daolocais daolocais = new Daolocais();
            if (Daolocais.Salvar(lc))
            {
                Console.WriteLine("Locais salvo comsucesso");
            }
        }
    }
}
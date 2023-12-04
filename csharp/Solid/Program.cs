namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleResponsibility
            //OpenClose();
           // liskov();

            Console.ReadKey();
        }
        static void SingleResponsibility()
        {
            Produto p = new Produto(1, "Manga",7);
            CrudProduto crudProd = new CrudProduto();
            crudProd.salvar(p);
            crudProd.salvar(new Produto(2, "Uva", 5));
            crudProd.salvar(new Produto(3, "Morango", 6));
            crudProd.alterar(p);
            crudProd.consultar(p);

        }
        static void OpenClose()
        {
            new PersistenciaEmArquivo().salvar(new Fatura());
            new PersistenciaEmBDD().salvar(new Fatura());
        }
        static void liskov()
        {
            GerenciaPersitenciaFatura gp1 = new GerenciaPersitenciaFatura(new PersistenciaEmArquivo());
            gp1.executar(new Fatura());

            GerenciaPersitenciaFatura gp2 = new GerenciaPersitenciaFatura(new PersistenciaEmBDD());
            gp2.executar(new Fatura());
        }
    }
}
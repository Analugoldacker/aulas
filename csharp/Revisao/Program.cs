namespace revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criarMoto();
            //criarPessoa();
            criarprodutos();

            Console.ReadKey();
        }
        static void criarMoto()
        {
            /*A partir da classe Veiculo cria a classe Moto com o atributo cilindradas. 
             *A partir da classe Moto crie classes derivadas com atributos específicos 
             *para Moto de passeio e de competição. Criar métodos polimórficos para listar os atributos de cada objeto criado.*/

            /*criar*/
            Moto moto = new Moto() {Marca = "Honda", Cilindradas = 150};
            Console.WriteLine(moto.ToString());
            Moto xre = new Moto("Honda", 190);
            Console.WriteLine(xre.ToString());

            //  MotoCompeticao motoCompeticao = new MotoCompeticao() { Marca="Agrale", Cilindradas=180, NumeroCompetidor=25};
            //  Console.WriteLine(motoCompeticao.ToString());

            MotoCompeticao motoc = new MotoCompeticao("BMW", 1100, 53);
            Console.WriteLine(motoc.ToString());
        }
        static void criarPessoa()
        {
            /*Criar uma coleção  com chave do tipo string recebendo o nome de uma pessoa e no valor armazenar um objeto do tipo pessoa.*/

            /*SortedList<string, Pessoa> pessoas = new SortedList<string, Pessoa>();
            pessoas.Add("maria", new Pessoa() { Id=1, Nome="Maria", Email="maria@gmail.com"});
            pessoas.Add("joao", new Pessoa() { Id = 2, Nome = "Joao", Email = "joao@gmail.com" });
            pessoas.Add("Antonio", new Pessoa() { Id = 3, Nome = "Antonio", Email = "antonio@gmail.com" });

            Console.WriteLine(pessoas["joao"].ToString());
            Console.WriteLine("Listas todos"); 
            IList<string> chaves = pessoas.Keys;
            foreach (string k in chaves)
            {
                Console.WriteLine($"Key:{k}  Value:{pessoas[k].ToString()}");
            }*/

            SortedList<string, Pessoa> pessoas = new SortedList<string, Pessoa>();

            pessoas.Add(" Analú", new Pessoa() { Id = 1, Nome = "Analú", Email = "Analu@gmail.com" });
            pessoas.Add(" Allana", new Pessoa() { Id = 2, Nome = "Allana", Email = "Allana@gmail.com" });
            pessoas.Add(" Mikaella", new Pessoa() { Id = 1, Nome = "Mikaella", Email = "Mikaella@gmail.com" });

            Console.WriteLine(pessoas[" Allana"].ToString());

            /*Console.WriteLine("Listar todos os nomes");
            IList<string> chaves = pessoas.Keys;
            foreach (string k in chaves)
            {
                Console.WriteLine($"Key:{k}  Value:{pessoas[k].ToString()}");
            }*/

        }
        static void criarprodutos()
        {
            /*Criar uma coleção que armazena uma lista de produtos. Não deve permitir informar produtos duplicados.*/

            LinkedList<Produtos> produto = new LinkedList<Produtos>();
            (produto, new Produtos(1, "Milho"));
            inserirProduto(produto, new Produtos(2, "Trigo"));
            inserirProduto(produto, new Produtos(3, "Arroz"));
            inserirProduto(produto, new Produtos(3, "Arroz"));
        }
    }    
}
namespace atividadeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criarPessoa();
            //criaCarros();
            //criarCalculadora();
            //criarRetangulo();
              criarProduto();
        }
        static void criarPessoa()
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "maria";
            p1.email = "maria@gmail.com";
            p1.display();

            Pessoa p2 = new Pessoa();
            p2.nome = "jose";
            p2.email = "jose@gmail.com";
            p2.display();
        }
        static void criaCarros()
        {
            /*Criar a classe Carro com os seguintes atributos: placa, marca, modelo, cor, criar o método display;*/

            Carro c1 = new Carro();
            c1.placa = "abc-1234";
            c1.marca = "chevrolet";
            c1.modelo = "agile";
            c1.cor = "branco";
            c1.capacidadeTanqueCompustivel = 40;
            c1.display();
            double x = c1.autonomia(10);
            Console.WriteLine(x);
        }
        static void criarCalculadora()
        {
            /*Cria uma classe calculadora com dois atributos; criar os métodos de adição, subtração, multiplicação e divisão.*/

            Calculadora calc = new Calculadora();
            calc.n1 = 10;
            calc.n2 = 20;
            calc.n3 = 0;
            calc.somar();
            calc.subtrair();
            calc.multiplicar();
            calc.dividir();
        }
        static void criarRetangulo()
        {
            /*Criar uma classe Retangulo, informando seus atributos e  métodos para calcular a área e perímetro.*/

            Retangulo ret = new Retangulo();
            ret.altura1 = 10;
            ret.altura2 = 10;
            ret.largura1 = 15;
            ret.largura2 = 15;
            ret.area();
            ret.perimetro();
        }
        static void criarProduto()
        {
            /*Criar uma classe de produtos com código 1, descrição morango, estoque 3  e valor Unitário 1. 
             *Criar métodos que retorne o preço do produto aplicando um desconto e um acréscimo.*/

            Produto pro = new Produto();
            pro.codigo = 1;
            pro.descricao = "morango";
            pro.estoque = 10;
            pro.valorUnitário = 95;

            var x = pro.valorDesconto(10);
            Console.WriteLine(x);

            var y = pro.valorAcrescimo(10);
            Console.WriteLine(y);

            



        }

    }
}
namespace attpolimorfismo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // criaClientes();
            // criarVeiculos();
            criaMoto();
            Console.ReadKey();
        }

        static void criaMoto()
        {
            Moto moto = new Moto() { Marca = "Yamaha", Cilindradas = 300 };
            Console.WriteLine(moto.ToString());

            Moto xre = new Moto("Honda", 190);
            Console.WriteLine(xre.ToString());

            //  MotoCompeticao motoCompeticao = new MotoCompeticao() { Marca="Agrale", Cilindradas=180, NumeroCompetidor=25};
            //  Console.WriteLine(motoCompeticao.ToString());

            MotoCopeticao motoc = new MotoCopeticao("BMW", 1100, 53);
            Console.WriteLine(motoc.ToString());
        }

        static void criaClientes()
        {
            Cliente cliente = new Cliente() { Id = 1, Nome = "Maria", Cpf = "123" };
            Console.WriteLine(cliente.ToString());

            Cliente cli = new Cliente(2, "João", "456");
            Console.WriteLine(cli.ToString());
        }
        static void criarVeiculos()
        {
            Veiculo veiculo = new Veiculo() { Marca = "Jeep" };
            Console.WriteLine(veiculo.Marca);
            veiculo.ronco();

            Carro carro = new Carro() { Modelo = "Renegade" };
            carro.Marca = "Jeep";
            Console.WriteLine(carro.Modelo + " " + carro.Marca);
            carro.ronco();
        }
    }
}
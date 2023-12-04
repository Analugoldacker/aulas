namespace herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarroVeiculo();

            Console.ReadLine();
        }
        static void CarroVeiculo()
        {
            /*Veiculo veiculo = new Veiculo() { Marca = "Jeep" };
            Console.WriteLine(veiculo.ToString());
            veiculo.ToString();*/

            Carro carro = new Carro() { Modelo = "Renegate"};
            carro.Marca = "Jeep";
            Console.WriteLine(carro.Marca + " " +  carro.Modelo);
            carro.ronco();

        }
        static void ClientesPessoas()
        {
            Cliente cliente = new Cliente() { Id = 1, Nome = "Analú", Cpf = "123.456.789-10" };
            Console.WriteLine(cliente.ToString());
        }
    }   
}
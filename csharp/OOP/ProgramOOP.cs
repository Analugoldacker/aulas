namespace aulaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoa p1 = new pessoa();
            p1.nome = "maria";
            p1.email = "maria@gmail.com";
            p1.display();

            pessoa p2 = new pessoa();
            p2.nome = "jose";
            p2.email = "jose@gmail.com";
            p2.display();

            Console.ReadLine();
        }
    }
}
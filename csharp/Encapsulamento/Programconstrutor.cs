using atividadeOOP;

namespace encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //construtor();
            //propriedades();
            attcarros();
           // attcalculadora();


            Console.ReadKey();

        }
        static void construtor()
        {   /*metodo normal*/

            Person p = new Person();
            p.name = "Analú";
            p.age = 16;
            Console.WriteLine(p.ToString());

            /*metodo construtor*/

            Person p1 = new Person() { name = "Mikaella", age = 6 };
            Console.WriteLine(p1.ToString());

            Person p2 = new Person("Allana", 2);
            Console.WriteLine(p2.ToString());

            Person p3 = new Person("Julio");
            Console.WriteLine(p3.ToString());

        }
        static void propriedades()
        {
            Pessoa p = new Pessoa();
            p.Nome = "Zé";
            p.Idade = 20;
            Console.WriteLine(p.ToString());
            Console.WriteLine($"Situação: {p.Situacao}");
        }
        static void attcarros()
        {
            Carro c = new Carro()
            { Placa = "abc-1234", Marca = "chevrolet", Modelo = "agile", Cor = "branco"};
            Console.WriteLine(c.ToString());/*certo*/

            Carro c1 = new Carro("abc","abd","xpt","123");
            Console.WriteLine(c1.ToString());/*errro*/
        }
        static void attcalculadora()
        {

            Calculadora calc = new Calculadora() {};

            calc.n1 = 10;
            calc.n2 = 20;
            calc.n3 = 0;
            calc.somar();
            calc.subtrair();
            calc.multiplicar();
            calc.dividir();

        }
    }
}
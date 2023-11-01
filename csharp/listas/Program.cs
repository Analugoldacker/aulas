namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //explicacao();
              atividade1();

            Console.ReadKey();

        }
        static void explicacao()
        {
            /* tipos de lista*/

            //List<string> list = new List<string>();escrita
            //List<int> numeros = new List<int>(); numeros
            //List<string> person = new List<string>(); qualque outra coisa

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Id = 1, Name = "Mika" });
            persons.Add(new Person() { Id = 2, Name = "Ana" });
            persons.Add(new Person() { Id = 3, Name = "Allana" });

            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }


            /*List<string> list = new List<string>();
            list.Add("Ana");
            Console.WriteLine(list.Count);

            list.Add("Mika"); adicionar
            list.Add("Allana");
            Console.WriteLine(list.Count);

            Console.WriteLine("Imprimindo usando forma não indexada");
            foreach (string item in list) 
            {
                Console.WriteLine(item);
            }

            int posSearch = list.IndexOf("Allana");
            Console.WriteLine(posSearch);
            list[posSearch] = "Allana Vitoria"; alterar
            list.Remove("kaleu"); remover

            Console.WriteLine("Imprimindo usando forma indexada");
            for(int i =  0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);/*forma indexada*/

        }
      
        static void atividade1()
        {
            List<Carro> carros= new List<Carro>();

            while (true)
            {
                Console.WriteLine("Informe uma opçao:");
                Console.WriteLine("1- Inserir");
                Console.WriteLine("2- Editar");
                Console.WriteLine("3- Excuir");
                Console.WriteLine("4- Consultar Todos");
                Console.WriteLine("5- Consultar Pelo Id");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:Carro carroProcurando = getCarro(carros, "abc-1234");
                        break;

                    case 2:Console.WriteLine("editar");                        
                        break;

                    case 3:Console.WriteLine("excluir");                       
                        break;

                    case 4:Console.WriteLine("consultar todos");
                        break;

                    case 5:Console.WriteLine("consultar pelo id");                        
                        break;

                    default:Console.WriteLine("opcao invalida");
                        break;

                }
                //Console.Clear();
            }
            /*INSERRIR*/
            /*Carro carros = new Carro();

            Console.WriteLine("Infome Placa:");
            Console.WriteLine("Placa: ");
            carros.Placa = Console.ReadLine();

            Console.WriteLine("Infome :");
            Console.WriteLine("Placa: ");
            carros.Placa = Console.ReadLine();*/
        }
        static Carro getCarro(string placa,  )
    }
}
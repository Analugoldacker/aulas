namespace listas
{
    internal class PROGRAMAM
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
            List<Carro> carros = new List<Carro>();
            while (true)
            {
                Console.WriteLine("Informe uma opção: ");
                Console.WriteLine("1 - Inserir ");
                Console.WriteLine("2 - Editar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Consultar todos ");
                Console.WriteLine("5 - Consulta pelo ID");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Carro carroProcurado = getCarro(carros, "LZZ-1976");
                            if (carroProcurado != null)
                            {
                                Console.WriteLine("Carro já cadastrado");
                            }
                            else
                            {
                                carros.Add(new Carro() { Placa = "LZZ-1976", Modelo = "Fuscão" });
                            }

                            break;
                        }
                    case 2:
                        {
                            Carro carroProcurado = getCarro(carros, "LZZ-1976");
                            if (carroProcurado == null)
                            {
                                Console.WriteLine("Carro não está cadastrado");
                            }
                            else
                            {
                                carroProcurado.Modelo = "fusquinha";
                            }

                            break;
                        }
                    case 3:
                        Console.WriteLine("Excluindo");
                        break;
                    case 4:
                        {
                            foreach (Carro car in carros)
                            {
                                Console.WriteLine(car.ToString());
                            }
                            break;
                        }
                    case 5:
                        Console.WriteLine("Consultando pelo ID");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                //Console.Clear();
            }
        }
        static Carro getCarro(List<Carro> origem, string placa)
        {
            Carro carro = null;
            foreach (Carro car in origem)
            {
                if (car.Placa.Equals(placa))
                {
                    carro = car;
                }
            }
            return carro;

        }
    }
}
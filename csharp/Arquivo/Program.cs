namespace Arquivos
{
    internal class Program
    {
        static string path = @"C:\Users\analu.baade\Desktop\aulas\csharp\Arquivo\documento.txt";
        static void Main(string[] args)
        {
            //exercicio();
            exercicio1();

            Console.ReadKey();
        }
        static void exercicio()
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine("1 - Gravar");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("3 - excluir");
                Console.WriteLine("4 - sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        gravar();
                        break;
                    case 2:
                        lerArquivo();
                        break;
                    case 3:
                        excluir();
                        break;
                    case 4:
                        sair();
                        break;
                }
            }

            static void sair()
            {
                Console.WriteLine("Saindo do programa");
            }
            static void gravar()
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        Console.WriteLine("Informe nome: ");
                        string nome = Console.ReadLine();
                        sw.WriteLine(nome);

                        Console.WriteLine("Informe email: ");
                        string email = Console.ReadLine();
                        sw.WriteLine(email);

                        Console.WriteLine("Informe telefone: ");
                        string telefone = Console.ReadLine();
                        sw.WriteLine(telefone);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Console.WriteLine("Informe nome: ");
                        string nome = Console.ReadLine();
                        sw.WriteLine(nome);

                        Console.WriteLine("Informe email: ");
                        string email = Console.ReadLine();
                        sw.WriteLine(email);

                        Console.WriteLine("Informe telefone: ");
                        string telefone = Console.ReadLine();
                        sw.WriteLine(telefone);
                    }
                }
            }
            static void excluir()
            {
                File.Delete(path);
            }
            static void criarArquivo()
            {
                if (!File.Exists(path))
                {
                    // File.CreateText(path);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(" ");
                    }
                }
            }
            static void lerArquivo()
            {
                try
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (FileNotFoundException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
        }
        static void exercicio1()
        {
            Manipular manipular = new Manipular();
            manipular.carregarDoArquivo();
            int opcao = 0;
            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("1 - Gravar");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("5 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            switch (opcao)
            {
                case 1: manipular.salvar(new Contato() { Id = 1, Nome = "maria", Email = "maria@gmail.com" }); break;
                case 5: manipular.salvarNoArquivo(); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
            static void sair()
            {
                Console.WriteLine("Saindo do programa");
            }
            static void gravar()
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        Console.WriteLine("Informe nome: ");
                        string nome = Console.ReadLine();
                        sw.WriteLine(nome);

                        Console.WriteLine("Informe email: ");
                        string email = Console.ReadLine();
                        sw.WriteLine(email);

                        Console.WriteLine("Informe telefone: ");
                        string telefone = Console.ReadLine();
                        sw.WriteLine(telefone);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Console.WriteLine("Informe nome: ");
                        string nome = Console.ReadLine();
                        sw.WriteLine(nome);

                        Console.WriteLine("Informe email: ");
                        string email = Console.ReadLine();
                        sw.WriteLine(email);

                        Console.WriteLine("Informe telefone: ");
                        string telefone = Console.ReadLine();
                        sw.WriteLine(telefone);
                    }
                }
            }
            static void excluir()
            {
                File.Delete(path);
            }
            static void criarArquivo()
            {
                if (!File.Exists(path))
                {
                    // File.CreateText(path);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(" ");
                    }
                }
            }
            static void lerArquivo()
            {
                try
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (FileNotFoundException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
        }
    }
    
}
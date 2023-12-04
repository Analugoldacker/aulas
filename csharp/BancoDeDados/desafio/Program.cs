using AttBDD.dao;
using AttBDD.Pro;
using static System.Net.Mime.MediaTypeNames;

namespace AttBDD
{
    internal class Program
    {
        private static object salvar;

        static void Main(string[] args)
        {
            atividade();


            Console.ReadLine();

        }
        static void atividade()
        {
            /*Criar uma classe de categoria com um  id e descrição;
             *Criar uma tabela no banco de dados e criar um CRUD de categorias;
             *Criar uma classe produto com os atributos id, nome, valor unitário,
             *Quantidade em estoque e uma agregação com categoria. Criar um CRUD de produto;
             *criar um método que permita consultar todos os produtos de uma determinada categoria. 
             *Criar um programa que permita ao usuário realizar todas as operações desenvolvidas*/

            int opcao = 0;
            while (opcao != 10)
            {
               // Console.Clear();
                Console.WriteLine("1 - Salvar Categoria");
                Console.WriteLine("2 - Consultar Categoria por id");
                Console.WriteLine("3 - Consultar todas as Categoria");
                Console.WriteLine("4 - Editar categoria pelo ID");
                Console.WriteLine("5 - Excluir");
                Console.WriteLine("10 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        salvarCategoria();
                        break;
                    case 2:
                        consultarCategoria();
                        break;
                    case 3:
                        consultarTodasCategorias();
                        break;
                    case 4: editar(); break;
                    case 5:
                        excluir(); break;
                    case 10:
                        sair();
                        break;
                }
            }

            static void salvarCategoria()
            {
                Console.Write("Qual categoria voce deseja adicionar: ");
                string resposta = Console.ReadLine();

                Categoria cat = new Categoria(1, resposta);

                DaoCategoria daocategoria = new DaoCategoria();
                if (daocategoria.salvar(cat))
                {
                    Console.WriteLine("Categoria salvo com sucesso");
                }
            }

            static void consultarTodasCategorias() {
                List<Categoria> categorias = new DaoCategoria().consultar();
                foreach(Categoria c in categorias)
                {
                    Console.WriteLine($"Categoria: {c}");
                }
            }

            static void consultarCategoria()
            {
               DaoCategoria daoCategoria = new DaoCategoria();
                Console.WriteLine("Informe código que deseja consultar? ");
                int id = Convert.ToInt32(Console.ReadLine());
                Categoria cat = daoCategoria.consultar(id);
                Console.WriteLine(cat.ToString());
                
            }

            static void sair()
            {
                Console.WriteLine("Saindo do programa");
            }

            void excluir()
            {
                Console.WriteLine("Qual o id da categoria que voce deseja excluir?");
                int respostaId = Convert.ToInt32(Console.ReadLine());

                DaoCategoria daoCategoria = new();

                daoCategoria.excluir(respostaId);
            }

            void editar()
            {
                Console.Write("Qual o id da categoria que voce deseja editar: ");
                int respostaId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo valor da descição: ");
                string novaDescricao = Console.ReadLine();

                Categoria novaCategoria = new Categoria(respostaId, novaDescricao);

                DaoCategoria daoCategoria = new();

                daoCategoria.alterar(novaCategoria);

            }
        }

    }
}
    

using AttBDD.dao;
using AttBDD.Pro;

namespace attbdd
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
                Console.WriteLine("1 - Salvar categoria");
                Console.WriteLine("2 - Consultar categoria por id");
                Console.WriteLine("3 - Consultar todas as Categoria");
                Console.WriteLine("4 - Editar categoria pelo ID");
                Console.WriteLine("5 - Excluir categoria");
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
                    case 4: 
                        editarCategoria();
                        break;
                    case 5:
                        excluirCategoria(); 
                        break;
                    case 6:
                        salvarProduto();
                        break;
                    case 7:
                        consultarProduto();
                        break;
                    case 8:
                        consultarTodosProdutos();
                        break;
                    case 9:
                        editarProduto();
                        break;
                    case 10:
                        excluirProdutos();
                        break;
                    case 11:
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

            static void consultarCategoria()
            {
                DaoCategoria daoCategoria = new DaoCategoria();
                Console.WriteLine("Informe código que deseja consultar? ");
                int id = Convert.ToInt32(Console.ReadLine());
                Categoria cat = daoCategoria.consultar(id);
                Console.WriteLine(cat.ToString());

            }

            static void consultarTodasCategorias()
            {
                List<Categoria> categorias = new DaoCategoria().consultar();
                foreach (Categoria c in categorias)
                {
                    Console.WriteLine($"Categoria: {c}");
                }
            }

            void editarCategoria()
            {
                Console.Write("Qual o id da categoria que voce deseja editar: ");
                int respostaId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo valor da descição: ");
                string novaDescricao = Console.ReadLine();

                Categoria novaCategoria = new Categoria(respostaId, novaDescricao);

                DaoCategoria daoCategoria = new();

                daoCategoria.alterar(novaCategoria);

            }

            void excluirCategoria()
            {
                Console.WriteLine("Qual o id da categoria que voce deseja excluir?");
                int respostaId = Convert.ToInt32(Console.ReadLine());

                DaoCategoria daoCategoria = new();

                daoCategoria.excluir(respostaId);
            }

            static void salvarProduto()
            {
                Console.Write("Qual produto voce deseja adicionar: ");
                string resposta = Console.ReadLine();

                Produto pro = new Produto(1,"morango","");

                DaoProduto daoProduto = new DaoProduto();
                if (daoProduto.salvar(pro))
                {
                    Console.WriteLine("Produto salvo com sucesso");
                }
            }

            static void consultarProduto()
            {
                DaoProduto daoProduto = new DaoProduto();
                Console.WriteLine("Informe código que deseja consultar? ");
                int id = Convert.ToInt32(Console.ReadLine());
                Produto pro = daoProduto.consultar(id);
                Console.WriteLine(pro.ToString());

            }

            static void consultarTodosProdutos()
            {
                List<Produto> produtos = new DaoProduto().consultar();
                foreach (Produto p in produtos)
                {
                    Console.WriteLine($"Produto: {p}");
                }
            }

            void editarProduto()
            {
                Console.Write("Qual o id doproduto que voce deseja editar: ");
                int respostaId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o novo valor do Nome: ");
                string novoproduto = Console.ReadLine();

                Console.Write("Digite o novo valor do Valor Unitario: ");
                string novoValorUnitario = Console.ReadLine();

                Produto produto = new Produto(respostaId, novoproduto,novoValorUnitario);

                DaoProduto daoProduto = new();

                daoProduto.alterar(novoproduto, novoValorUnitario);

            }

            void excluirProdutos()
            {
                Console.WriteLine("Qual o id do produto que voce deseja excluir?");
                int respostaId = Convert.ToInt32(Console.ReadLine());

                DaoProduto daoProduto = new();

                daoProduto.excluir(respostaId);
            }

            static void sair()
            {
                Console.WriteLine("Saindo do programa");
            }

        }

        
    }
}
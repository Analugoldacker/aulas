using AulaPOO.Agregacao.Produto;

namespace AulaPOO.Agregacao.Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //colecaoLinkedList();
            colecaoKeyValue();
            Console.ReadKey();
        }

        static void colecaoKeyValue()
        {
            SortedList<string, string> files = new SortedList<string, string>();
            files.Add("txt", "notepad.exe");
            files.Add("doc", "winword.exe");
            files.Add("xls", "excel.exe");

            Console.WriteLine(files.Values.ToArray()[0]);
            Console.WriteLine(files.Keys.ToArray()[0]);

            Object[] valores = files.Values.ToArray();
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            IList<string> chaves = files.Keys;
            foreach (string k in chaves)
            {
                Console.WriteLine($"Key:{k}  Value:{files[k]}");
            }
            Console.WriteLine("");
            foreach (KeyValuePair<string, string> k in files)
            {
                Console.WriteLine($"Key:{k.Key}  Value:{k.Value}");
            }

        }

        static void colecaoLinkedList()
        {
            LinkedList<string> nomes = new LinkedList<string>();
            nomes.AddFirst("Ana");
            nomes.AddLast("Pedro");
            nomes.AddLast("Maria");

            showLinkedList(nomes);
            LinkedListNode<string> x = nomes.Find("Pedro");
            Console.WriteLine(x);
            Console.WriteLine(x.Value);

            LinkedListNode<string> anterior = x.Previous;
            Console.WriteLine(anterior.Value);

            LinkedListNode<string> proximo = x.Next;
            Console.WriteLine(proximo.Value);

            nomes.AddBefore(x, "Luana");
            nomes.AddAfter(x, "Patricia");
            showLinkedList(nomes);

            nomes.RemoveFirst();
            nomes.RemoveLast();
            nomes.Remove(x);
            showLinkedList(nomes);


        }

        static void showLinkedList(LinkedList<string> lista)
        {
            Console.WriteLine("---");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }

        static void agregar()
        {
            Categoria cereais = new Categoria(1, "cereais");
            Console.WriteLine(cereais.ToString());

            Produto milho = new Produto()
            {
                Id = 10,
                Descricao = "Milho",
                Preco = 15.50,
                categoria = cereais
            };

            Console.WriteLine(milho.ToString());
        }
        static void explicacaoList()
        {
            /*O exemplo a seguir demonstra como adicionar, remover e inserir um objeto de negócios simples em um List<T>.*/

            //Cria uma lista de peças.
            List<Part> parts = new List<Part>();

            //Adiciona peças à lista.
            parts.Add(new Part() { PartName = "braço da manivela", PartId = 1234 });
            parts.Add(new Part() { PartName = "anel de corrente", PartId = 1334 });
            parts.Add(new Part() { PartName = "assento regular", PartId = 1434 });
            parts.Add(new Part() { PartName = "assento de banana", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassete", PartId = 1534 });
            parts.Add(new Part() { PartName = "alavanca de câmbio", PartId = 1634 });

            // Escreva as partes da lista. Isso chamará o método ToString substituído na classe Parte.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // Verifique a lista da peça #1734. Isso chama o método IEquatable.Equals da classe Part, que verifica a igualdade do PartId.
            Console.WriteLine("\nContains(\"1734\"): {0}",
            parts.Contains(new Part { PartId = 1734, PartName = "" }));

            //Insere um novo item na posição 2.
            Console.WriteLine("\nInsert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            //Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nRemove(\"1534\")");

            // Isso removerá a peça 1534 mesmo que o PartName seja diferente,porque o método Equals apenas verifica a igualdade do PartId.
            parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nRemoveAt(3)");

            // Isso removerá a parte no índice 3.
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

        }
    }
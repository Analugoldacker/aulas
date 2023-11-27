using LINQ;

namespace LINQ
{
    internal class Program
    {
        static List<Estudante> estudantes = new()
        {
            new Estudante { Id = 1, Nome = "Analú", Sobrenome = "Goldacker", Scores = new List<int> { 99, 100, 90, 94 } },
            new Estudante { Id = 2, Nome = "Julia", Sobrenome = "Monteiro", Scores = new List<int> { 99, 82, 81, 79 } },
            new Estudante { Id = 3, Nome = "Júlio", Sobrenome = "Gustzaki", Scores = new List<int> { 65, 70, 81, 76 } },
            new Estudante { Id = 4, Nome = "Pedro", Sobrenome = "Arthur", Scores = new List<int> { 54, 35, 64, 60 } },
            new Estudante { Id = 5, Nome = "Leticia", Sobrenome = "Bauer", Scores = new List<int> { 94, 92, 91, 91 } },
            new Estudante { Id = 6, Nome = "Kristina", Sobrenome = "Kraft", Scores = new List<int> { 63, 86, 35, 89} },
            new Estudante { Id = 7, Nome = "Stephany", Sobrenome = "Karoline", Scores = new List<int> { 98, 85, 89, 99} },
            new Estudante { Id = 8, Nome = "Patrick", Sobrenome = "Oliveira", Scores = new List<int> { 66, 55, 60, 65}},
        };

        static void Main(string[] args)
        {
            //exemploPar();
            //exemploImpar();
            //fltrarAlunos();
            //AlunosAprovados();
            //AlunosReprovados();
            AlunosMaiorMediaNota();
            AlunosMenorMediaNota();


            Console.ReadKey();
        }

        static void exemploPar()
        {
            // As três partes de uma consulta LINQ:
            Console.WriteLine("numeros pares: ");
            // 1. Fonte de dados.
            int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            // 2. Criação de consulta.
            // numQuery é um IEnumerable<int>
             var numerosPares =
             from num in numbers
             where (num % 2) == 0
             select num;

             // 3. Execução da consulta.
             foreach (int num in numerosPares)
             {
                 Console.Write("{0,1} ", num);
             }           
        }
        static void exemploImpar()
        {
            Console.WriteLine("numeros impares: ");
            int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            var numerosImpares =
            from num in numbers
            where (num % 2) != 0
            select num;

            foreach (int num in numerosImpares)
            {
                Console.Write("{0,1} ", num);
            }
        }
        static void fltrarAlunos()
        {
            IEnumerable <Estudante> estudenteQuery =
            from estudante in estudantes
            //Vai selecionar so quem tiver a media igual 90 ou maior
            //where estudante.Scores.[0] >= 90
            //where estudante.Nome.StratsWith("C")// Nome começando com C.
            //orderby estudante.Pontuacao.Average() descending //Pontuação decrescente
            //orderby estudante.Pontuacao.Average() ascending //Pontuação crescente
            select estudante;

            //List<Estudante> lista = estudanteQuery.ToList();
            Estudante[] lista = estudenteQuery.ToArray();

            foreach (Estudante est in lista)
            {
                Console.WriteLine($"Id: {est.Id} Nome: {est.Nome} Sobrenome :{est.Sobrenome} Media: {est.Scores.Average()}");
            }

        }
        static void AlunosAprovados()
        {
            IEnumerable<Estudante> aprovados =
            from estudante in estudantes
            where estudante.Scores.Average() >= 70
            select estudante;

            Estudante[] lista = aprovados.ToArray();

            foreach (Estudante est in aprovados)
            {                
                Console.WriteLine($"Id: {est.Id} Nome: {est.Nome} Sobrenome :{est.Sobrenome} Media: {est.Scores.Average()} Aprovados");
            }
           
        }
        static void AlunosReprovados()
        { 
            IEnumerable<Estudante> reprovados =
            from estudante in estudantes
            where estudante.Scores.Average() < 70
            select estudante;

            Estudante[] lista = reprovados.ToArray();

            foreach (Estudante est in reprovados)
            {
                Console.WriteLine($"Id: {est.Id} Nome: {est.Nome} Sobrenome :{est.Sobrenome} Media: {est.Scores.Average()} Reprovados");
            }

        }
        static void AlunosMaiorMediaNota()
        {

            Console.WriteLine($"Maior média: ");

            var Media =
            from estudante in estudantes
            let media = estudante.Scores.Average()
            select media;

            Console.WriteLine($"{Media.Max()}");

            Console.WriteLine($"Maior nota: ");

            var Nota =
            from estudante in estudantes
            let nota = estudante.Scores.Max()
            select nota;

            var x = Nota.Max();
            Console.WriteLine($"{x}");

            
        }
        static void AlunosMenorMediaNota()
        {
            Console.WriteLine($"Menor média: ");

            var Media =
            from estudante in estudantes
            let media = estudante.Scores.Average()
            select media;

            Console.WriteLine($"{Media.Min()}");

            Console.WriteLine($"Menor nota: ");

            var Nota =
            from estudante in estudantes
            let nota = estudante.Scores.Min()
            select nota;

            var x = Nota.Min();
            Console.WriteLine($"{x}");

        }
    }
    
}
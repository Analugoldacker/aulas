namespace Execao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // limitesArray();
            divisaoZero();
            Console.ReadKey();
        }

        static void divisaoZero()
        {
            try
            {
                int x = 20;
                int y = 2;
                float z = x / y;

                int[] numeros = { 1, 2, 3 };
                numeros[4] = 10;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fim do programa");
            }
        }
        static void limitesArray()
        {
            try
            {
                int[] numeros = { 1, 2, 3, 4, 5, 6 };
                int x = 10;

                if (x > numeros.Length - 1)
                {
                    throw new IndexOutOfRangeException($"O limite do array é {numeros.Length}");
                }

                numeros[x] = 1;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
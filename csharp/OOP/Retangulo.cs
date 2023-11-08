using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeOOP
{
    class Retangulo
    {
        public double largura1;
        public double largura2;
        public double altura1;
        public double altura2;

        public void area()
        {
            
            double resultado = largura1 * altura1;
            Console.WriteLine($"area é:" + $"{resultado}");

        }
        public void perimetro()
        {
            
            double resultado = altura1 + altura2 + largura1 + largura2;
            Console.WriteLine($"perimetro é:" + $"{resultado}");
        }
    }
}

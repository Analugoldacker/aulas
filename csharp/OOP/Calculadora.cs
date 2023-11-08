using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeOOP
{
    class Calculadora
    {
        public double n1;
        public double n2;
        public double n3;

        public void somar()
        {
            double resultado = n1 + n2;
            Console.WriteLine($"Somar:" + $"{resultado}");
        }
        public void subtrair()
        {
            double resultado = n1 - n2;
            Console.WriteLine($"subtrair:" + $"{resultado}");
        }
        public void multiplicar() 
        {
            double resultado = n1 * n2;
            Console.WriteLine($"multiplicar:" + $"{resultado}");
        }
        public void dividir()
        {  
            /*nao é possivel dividir por zero*/
            /*if (n3 == 0)
            {
                Console.WriteLine("Não é possivel dividir por Zero");
                return;
            }*/
            var resultado = n1 / n2;
            Console.WriteLine($"dividir:" + $"{resultado}");

        }

    }
}

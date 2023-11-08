using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeOOP
{
    class Carro
    {
        /*atributos da classe*/
        public string placa;
        public string marca;
        public string modelo;
        public string cor;
        public double capacidadeTanqueCompustivel;
        public void display()
        {
            /*metodos*/
            Console.WriteLine($"placa:" + $"{this.placa}");
            Console.WriteLine($"marca:" + $"{this.marca}");
            Console.WriteLine($"modelo:" + $"{this.modelo}");
            Console.WriteLine($"cor:" + $"{this.cor}");
        }
        public double autonomia(double mediaKm)
        {
            return capacidadeTanqueCompustivel * mediaKm;
        }
    }
}

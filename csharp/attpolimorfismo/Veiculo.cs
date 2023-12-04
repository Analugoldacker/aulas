using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attpolimorfismo
{
    class Veiculo
    {
        public string Marca { get; set; }
        public void ronco()
        {
            Console.WriteLine("Ronco do veiculo");
        }
        public string ToString()
        {
            return $"Marca:{Marca} ";
        }

        public Veiculo() { }
        public Veiculo(string marca)
        {
            Marca = marca;
        }
    }
}

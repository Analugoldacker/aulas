using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança
{
    class Carro : Veiculo
    {
        public string Modelo { get; set; }

        public void ronco()
        {
            Console.WriteLine("ronco do carro");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança
{
    class Veiculo
    {
        public string Marca {  get; set; }

        public void ronco() 
        {
            Console.WriteLine("ronco de veiculo");
        }
    }
}

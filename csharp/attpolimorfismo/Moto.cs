using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attpolimorfismo
{
    class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto() { }
        public Moto(string marca, int cilindradas) : base(marca)
        {
            Cilindradas = cilindradas;
        }

        public string ToString()
        {
            return $"{base.ToString()} Cilindrada:{Cilindradas} ";
        }


    }
}

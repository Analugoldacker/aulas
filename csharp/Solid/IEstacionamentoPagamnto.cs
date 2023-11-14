using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface IEstacionamentoPagamnto
    {
        double calcularTaxa(Carro carro);
        void pagar(Carro carro);
    }
}

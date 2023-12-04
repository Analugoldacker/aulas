using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Estacionamento : IEstacionamento, IEstacionamentoPagamnto
    {
        public void estacionarCarro()
        {
            throw new NotImplementedException();
        }

        public void getCapacidade()
        {
            throw new NotImplementedException();
        }
        public void sairDaVagaComCarro()
        {
            throw new NotImplementedException();
        }

        public void pagar(Carro carro)
        {
            throw new NotImplementedException();
        }

        public double calcularTaxa(Carro carro)
        {
            throw new NotImplementedException();
        }

    }
}

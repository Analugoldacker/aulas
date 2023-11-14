using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    interface IEstacionamento
    {
        void estacionarCarro();
        void sairDaVagaComCarro();
        void getCapacidade();
    }
}

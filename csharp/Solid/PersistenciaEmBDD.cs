using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class PersistenciaEmBDD : IPersistenciaDaFatura
    {
        public void salvar(Fatura fatura)
        {
            Console.WriteLine("Salvando em Banco de dados");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class GerenciaPersitenciaFatura
    {
        private IPersistenciaDaFatura persistenciaDaFatura;
        public GerenciaPersitenciaFatura(IPersistenciaDaFatura persistencia)
        {
            persistenciaDaFatura = persistencia;
        }

        public void executar(Fatura fatura)
        {
            persistenciaDaFatura.salvar(fatura);
        }
    }
}


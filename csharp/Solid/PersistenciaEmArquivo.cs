using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class PersistenciaEmArquivo : IPersistenciaDaFatura
    {
        public void salvar(Fatura fatura)
        {
            Console.WriteLine("Salvando em arquivo");
        }
    }
}

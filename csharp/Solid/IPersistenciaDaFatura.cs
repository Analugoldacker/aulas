using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface IPersistenciaDaFatura
    {
        public void salvar(Fatura fatura);
    }
}

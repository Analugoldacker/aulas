using Genericos.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.interfaces
{
    public interface ICrud
    {
        public bool salvar(Contato contato);
        public List<Contato> consultar();
        public bool alterar(Contato contato);
        public Contato consultar(int id);
        public void excluir(int id);
    }
}

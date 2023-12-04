using Genericos.entidade;
using Genericos.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.daoGenerico
{
    internal class DaoContatoGenerico : IcrudGenerico<Contato>
    {
        public bool alterar(Contato t)
        {
            throw new NotImplementedException();
        }

        public List<Contato> consultar()
        {
            throw new NotImplementedException();
        }

        public Contato consultar(int id)
        {
            throw new NotImplementedException();
        }

        public void excluir(int id)
        {
            throw new NotImplementedException();
        }

        public bool salvar(Contato t)
        {
            throw new NotImplementedException();
        }
    }
}

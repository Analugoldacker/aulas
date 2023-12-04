using Genericos.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.interfaces
{
    public interface IcrudGenerico<T>
    {
        /*o genrico serve para duas classes e so trocar o nome d classe por "t"*/
        /*public bool salvar(Contato contato);
        public List<Contato> consultar();
        public bool alterar(Contato contato);
        public Contato consultar(int id);
        public void excluir(int id);*/

        public bool salvar(T t);
        public List<T> consultar();
        public bool alterar(T t);
        public T consultar(int id);
        public void excluir(int id);
    }
}

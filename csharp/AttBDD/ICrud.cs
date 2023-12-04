using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttBDD.interfaces
{
    public interface ICrud<T>
    {
        public bool salvar(T t);
        public List<T> consultar();
        public bool alterar(T t);
        public T consultar(int id);
        public void excluir(int id);
    }
}

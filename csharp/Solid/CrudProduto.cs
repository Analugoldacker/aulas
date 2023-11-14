using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class CrudProduto
    {
        List<Produto> produtos = new List<Produto>();
        public bool salvar(Produto prod)
        {
            produtos.Add(prod);
            return true;
        }
        public bool alterar(Produto prod)
        {
            Console.WriteLine("Alterando");
            return true;
        }
        public void consultar(Produto prod)
        {
            foreach(Produto produto in produtos)
            {
                Console.WriteLine(produto.ToString());
            }
        }
    }
}

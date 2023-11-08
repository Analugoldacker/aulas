using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Categoria categoria { get; set; }

        public string ToString()
        {
            return $"Id:{Id} Descricao:{Descricao} Preco:{Preco} Categoria:{categoria.ToString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttBDD.Pro
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ValorUnitario { get; set; }
        public string idcategoria { get; set; }

        public Produto() { }

        public Produto(int id, string nome, string valorUnitario)
        {
            Id = id;
            Nome = nome;
            ValorUnitario = valorUnitario;
        }
        public override string ToString()
        {
            return $"Id:{Id} - Nome:{Nome} Valor unitario:{ValorUnitario} Id categoria: {idcategoria}";
        }
    }
}

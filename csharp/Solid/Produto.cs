using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Produto
    {   public int Id { get; set; }
        public string Descricao { get; set; }  
        public double Preco {  get; set; }

        public Produto() { }
        public Produto(int id, string descricao, double preco) 
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }
        public string ToString()
        {
            return $"Id:{Id} Descrição:{Descricao} Preço:{Preco}";
        }
    }
}

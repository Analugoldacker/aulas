using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttBDD.Pro
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        
        public Categoria() { }
        public Categoria(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"Id:{Id} - Descrição:{Descricao}";
        }
    }
}

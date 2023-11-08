using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO.Agregacao.Produto
{
    class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Categoria() { }
        public Categoria(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
        public string ToString()
        {
            return $"{Id} {Descricao}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplementacao.entidade
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public Contato() { }
        public Contato(int id, string nome, string email, string fone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Fone = fone;
        }
    }
}

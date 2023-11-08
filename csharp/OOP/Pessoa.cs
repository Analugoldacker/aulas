using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeOOP
{
    class Pessoa
    {
        public string nome;
        public string email;

        public void display()
        {
            Console.WriteLine($"nome:" + $"{this.nome}");
            Console.WriteLine($"email:" + $"{this.email}");
        }
    }
}

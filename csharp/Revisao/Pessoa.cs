using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Email { get; set; }

        public string ToString()
        {
            return $" Id:{Id} Nome:{Nome} Email:{Email}";
        }

    }
}

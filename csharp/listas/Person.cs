using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoListas
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ToString()
        {
            return $"Id:{Id} Nome:{Name}";
        }
    }
}
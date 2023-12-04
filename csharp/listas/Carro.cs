using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioListas
{
    class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }

        public string ToString()
        {
            return $"Placa: {Placa}  Modelo:{Modelo}";
        }
    }
}
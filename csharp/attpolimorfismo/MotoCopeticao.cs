using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attpolimorfismo
{
    class MotoCopeticao : Moto
    {
        public int NumeroCompetidor { get; set; }
        public string ToString()
        {
            return $"{base.ToString()} Competidor:{NumeroCompetidor} ";
        }

        public MotoCopeticao() { }

        public MotoCopeticao(string marca, int cilindradas, int numeroCompetidor) : base(marca, cilindradas)
        {
            NumeroCompetidor = numeroCompetidor;
        }
    }
}

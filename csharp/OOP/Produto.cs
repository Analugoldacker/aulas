using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeOOP
{
    class Produto
    {
        public int codigo;
        public string descricao;
        public double estoque;
        public double valorUnitário;

        public double valorDesconto(double taxa)
        {
            return valorUnitário * (taxa / 100); 
        }
        public double valorAcrescimo(double taxa)
        {
            

            return valorUnitário + calcularAcrescimo(10);

        }
        public double calcularAcrescimo()
        {
            return valorUnitário + valorDesconto(10);
        }
        
    }
}

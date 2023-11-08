using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    class Pessoa
    {   /*propriedade*/
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome precisa ter no minimo três caracteres");
                }
                else
                {
                    nome = value;
                }
            }
        }
        public int Idade { get; set; }
        public string Situacao
        {
            get
            {
                string msg = "maior";
                if (Idade < 18) { msg = "menor"; }
                return msg;
            }
        }
        public string ToString()
        {
            return $"Nome: {nome}  Idade: {Idade}";

        }
    }
}

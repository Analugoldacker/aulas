using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace encapsulamento
{
    class Carro
    {
        private string placa;
        private string marca;
        private string modelo;
        private string cor;

        public Carro() 
        {
            //
        }

        public Carro(string placa, string marca, string modelo, string cor)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
        }
        public string Placa
        {
            get { return placa; }
            set
            {
                if (value.Length < 7)
                {
                    Console.WriteLine("Placa precisa ter no minimo sete caracteres");
                }
                else
                {
                    placa = value;
                }
            }
        }
        public string Marca
        {
            get { return marca; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Marca precisa ter no minimo três caracteres");
                }
                else
                {
                    marca = value;
                }
            }
        }
        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Modelo precisa ter no minimo três caracteres");
                }
                else
                {
                    modelo = value;
                }
            }
        }
        public string Cor
        {
            get { return cor; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Cor precisa ter no minimo quatro caracteres");
                }
                else
                {
                    cor = value;
                }
            }
        }

        public string ToString()
        {
            return $"Placa: {placa} Marca: {marca} Modelo: {modelo} Cor: {cor}";
        }
        
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos
{
    class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set;}
        public string Telefone { get; set;}
        public override string ToString()
        {
            return $"Nome:{Nome} , Email{Email} , Telefone{Telefone}";
        }
    }
}

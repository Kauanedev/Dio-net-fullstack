using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFundamentos.Common.Models
{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public int Idade { get; set; }


        //método
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}
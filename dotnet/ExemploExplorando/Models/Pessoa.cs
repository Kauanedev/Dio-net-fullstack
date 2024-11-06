using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        //Construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }

        public void Deconstruct(out string nome, out string sobrenome)
        //Desconstrutor
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome;
            set

            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade
        {
            get => _idade;
            set

            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser menor ou igual a zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}

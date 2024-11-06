using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AddAluno(Pessoa aluno)
        // A palavra void indica que esse método não retorna nada
        {
            Alunos.Add(aluno);
        }

        public int QntAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool DeletarAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}: ");

            for (int i = 0; i < Alunos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Alunos[i].NomeCompleto}");

            }
        }



    }
}
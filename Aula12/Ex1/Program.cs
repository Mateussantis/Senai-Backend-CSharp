using System;
using Ex1.Controller;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno = new AlunoController();
            aluno.Cadastrar();
            Console.Clear();
            aluno.Ler();
        }
    }
}

using Ex1.Models;
using System;

namespace Ex1.Controller
{
    public class AlunoController
    {
        AlunoModel aluno = new AlunoModel();
        public void Cadastrar() {
            System.Console.Write("Digite seu Nome: ");
            aluno.nome = Console.ReadLine();

            System.Console.Write("Digite o Curso: ");
            aluno.curso = Console.ReadLine();
            
            System.Console.Write("Digite sua idade: ");
            aluno.idade = int.Parse(Console.ReadLine());

            System.Console.Write("Digite seu Rg: ");
            aluno.rg = Console.ReadLine();
            
            System.Console.Write("Digite se é bolsista: ");
            aluno.bolsistas = bool.Parse(Console.ReadLine());
             
        }
        public void Ler() {
            System.Console.WriteLine(aluno.nome);
            System.Console.WriteLine(aluno.curso);
            System.Console.WriteLine(aluno.idade);
            System.Console.WriteLine(aluno.rg);
            System.Console.WriteLine(aluno.bolsistas);
        }
    }
}
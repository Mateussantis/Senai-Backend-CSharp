using System;
namespace ExemploPoo.Models
{
    public class AlunoModel
    {
        public string nome {get; set;}

        public string curso {get; set;}

        public string ra {get; set;}

        public int idade {get; set;}

        public void Estudar() {
            System.Console.WriteLine("Estou estudando!");            
        }

        public void PedirAjuda() {
            System.Console.WriteLine("Paulooo, ajuda aquiii!!!");
        }

        public void PedirIntervalo() {
            System.Console.WriteLine("Quero Caféeeeee!");
        }
        
        public void CadastrarAluno() {
            System.Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();

            System.Console.Write("Insira o nome do seu curso: ");
            curso = Console.ReadLine();

            System.Console.Write("Insira seu Ra: ");
            ra = Console.ReadLine();

            System.Console.Write("Insira sua idade: ");
            idade = int.Parse(Console.ReadLine());
        }

        public void ExibirAluno() {
            System.Console.WriteLine();
            System.Console.WriteLine(nome);
            System.Console.WriteLine(curso);
            System.Console.WriteLine(ra);
            System.Console.WriteLine(idade);
        }
    }
}
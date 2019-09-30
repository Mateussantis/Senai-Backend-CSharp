using Ex1.Model;
using System;
namespace Ex1.Controller
{
    public class PessoasController
    {

        PessoasModel pessoa = new PessoasModel();

        public void adicionar() {
            try {
            System.Console.Write("Digite seu nome: ");
            pessoa.nome = Console.ReadLine();

            System.Console.Write("Digite sua idade: ");
            pessoa.idade = int.Parse(Console.ReadLine());

            System.Console.Write("Digite seu peso: ");
            pessoa.peso = double.Parse(Console.ReadLine());

            System.Console.Write("Digite sua altura: ");
            pessoa.altura = double.Parse(Console.ReadLine());
            } catch (Exception ex) {
                System.Console.WriteLine("Erro, tente novamente!\n");

            }
        }

        public void ler () {
            System.Console.WriteLine();
            System.Console.WriteLine(pessoa.nome);
            System.Console.WriteLine(pessoa.idade);
            System.Console.WriteLine(pessoa.peso);
            System.Console.WriteLine(pessoa.altura);

        }

        public string Imc () {

            double formula = pessoa.peso / (pessoa.altura * 2);
            string texto;

            if (formula < 18.5) {
                texto = $"Voce esta com {formula}, abaixo do peso !!! ";
            }
            else if (formula >= 18.5 && formula <= 25) {
                texto = $"Voce esta com {formula}, Peso normal !!! ";        
            }
            else if (formula >= 26 && formula <= 30) {
                texto = $"Voce esta com {formula}, SobrePeso !!! ";        
            }
            else if (formula >= 31 && formula <= 35) {
                texto = $"Voce esta com {formula}, Obesidade nivel 1 !!! ";        
            }
            else if (formula >= 36 && formula <= 39) {
                texto = $"Voce esta com {formula}, Obesidade nivel 2 !!! ";        
            }
            else {
                texto = $"Voce esta com {formula}, Obesidade nivel 3 !!! ";
            }
            return texto;

        }

        
    }
}
using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

            Console.Write("Digite Seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite Seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite idade: ");
            int idade = int.Parse(Console.ReadLine());
            
            Console.Write("Digite peso: ");
            double peso = double.Parse(Console.ReadLine());

            MostraInfos();
            MostraInfos(nome, sobrenome);
            MostraInfos(idade, nome, peso);

            }

            catch(Exception ex) {
                Console.WriteLine("Erro, digite as informaçoes corretamente!!!" ); 
            }

            
        }

        static void MostraInfos() {
            Console.WriteLine("Razão social do Senai!!!\n");
        }
        static void MostraInfos(string nome, string sobrenome) {
            Console.WriteLine(nome, sobrenome);
        }
        static void MostraInfos(int idade, string nome, double peso) {
            Console.WriteLine(nome, idade, peso);
        }
    }
}

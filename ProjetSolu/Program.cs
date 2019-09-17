using System;

namespace ProjetSolu
{
    class Program
    {
        static void Main(string[] args)
        {

            String tipodepessoa, nome, email, confirmar;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Cadastro Valer!");

            Console.WriteLine();

            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu email: ");
            email = Console.ReadLine();

            Console.Write("Cpf (11) ou Cnpj (14): ");
            tipodepessoa = Console.ReadLine();     

            Console.Write("Para confirmar seu cadastro, digite (1), para cancelar(2): "); 
            confirmar = Console.ReadLine(); 

            if (confirmar == "1" && tipodepessoa == "11") {
                Console.WriteLine("Parabens, olhe as ofertas disponiveis na Home!!!");
                Console.WriteLine();
            }
            else if (confirmar == "1" && tipodepessoa == "14") {
                Console.WriteLine("Parabens, voce esta pronto para vender!!!");
                Console.WriteLine();
            }
            else if (confirmar == "1" && tipodepessoa != "11" || confirmar == "1" && tipodepessoa != "14") {
                Console.WriteLine("Não foi possivel realizar seu cadastro, CPF ou CNPJ Invalido!!!");
                Console.WriteLine();
            }
            else if (confirmar != "1" && confirmar!= "2" && tipodepessoa != "11" || confirmar != "1" && confirmar != "2" && tipodepessoa != "14") {
                Console.WriteLine("Voce nao confirmou, nem cancelou, coloque uma opçao valida!!!");
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Voce acabou de cancelar seu cadastro!!!");
                Console.WriteLine();
            }
        }
    }
}

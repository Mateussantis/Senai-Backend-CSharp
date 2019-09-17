using System;

namespace ProjetSolu2
{
    class Program
    {
        static void Main(string[] args)
        {
            String log;
            Console.WriteLine();
            Console.Write("Logar como (usuario) ou (admin): ");
            log = Console.ReadLine();

            if (log == "usuario") {
                Console.WriteLine("Voce esta logado como usuario!!!");
                Console.WriteLine();
                Console.WriteLine("Perfil (1)");
                Console.WriteLine("Sair (sair)");
                String opcao;
                Console.Write("Escolha uma opção do menu: ");
                opcao = Console.ReadLine();
                    if (opcao == "1"){
                        Console.WriteLine();
                        Console.WriteLine("Ofertas..");
                        Console.WriteLine("Dois produtos em reserva");
                    }
                    else if (opcao == "sair") {
                        Console.WriteLine();
                        Console.WriteLine("Deslogado com sucesso!");
                    }
                    else {
                        Console.WriteLine("ERRO!!");
                    }
            }
            else if (log == "admin") {
                Console.WriteLine("Voce esta logado como admin!!!");
                Console.WriteLine();
                Console.WriteLine("Gerenciar produtos (1)");
                Console.WriteLine("Sair (sair)");
                String opcao;
                Console.Write("Escolha uma opção do menu: ");
                opcao = Console.ReadLine();
                    if (opcao == "1"){
                        Console.WriteLine();
                        Console.WriteLine("Produto 1, vendido!");
                        Console.WriteLine("Produto 2, em espera!");
                    }
                    else if (opcao == "sair") {
                        Console.WriteLine();
                        Console.WriteLine("Deslogado com sucesso!");
                    }
                    else {
                        Console.WriteLine("ERRO!!");
                    }
            }
            else {
                Console.WriteLine("ERRO!!!");
                Console.WriteLine();
            }

        }
    }
}

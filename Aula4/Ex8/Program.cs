using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new String [5];
            String[] origem = new String [5];
            String[] destino = new String [5];
            DateTime[] data_ida = new DateTime [5];
            DateTime[] data_volta = new DateTime [5];
            string sair = "";

            while(sair != "0") {    
                
            Console.WriteLine("\nMenu\n");
            Console.WriteLine("1 - Cadastrar voo!");
            Console.WriteLine("2 - Listar Infos!");
            Console.WriteLine("0 - Sair!\n");

            Console.Write("\nDigite uma opção: ");
            sair = Console.ReadLine();

            switch (sair) {

                case "1" :
                    for (int i = 0; i <= 4; i++) {
                        
                        Console.WriteLine("");

                        Console.Write($"Digite o {i+1} nome: ");
                        nome[i] = Console.ReadLine();

                        Console.Write($"Digite o {i+1} origem: ");
                        origem[i] = Console.ReadLine();

                        Console.Write($"Digite a {i+1} destino: ");
                        destino[i] = Console.ReadLine();

                        Console.Write($"Digite o {i+1} data: ");
                        data_ida[i] =   DateTime.Parse(Console.ReadLine());

                        Console.Write($"Digite o {i+1} data: ");
                        data_volta[i] = DateTime.Parse(Console.ReadLine());
                }                                        
                break;

                case "2" :
                    for (int i = 0; i <= 4; i++) {
                        if (nome[i] != "" && origem[i] != "" && destino[i] != "" && data_ida[i] != null && data_volta[i] != null) {
                        Console.WriteLine($"O passageiro {i+1}");
                        Console.WriteLine("Passageiro: " +nome[i]);
                        Console.WriteLine("A origem: " +origem[i]);
                        Console.WriteLine("O destino é: " +destino[i]);
                        Console.WriteLine("A data de ida é: " +data_ida[i]);
                        Console.WriteLine("A data de volta é:" +data_volta[i]);
                        Console.WriteLine("");
                        }
                        else {
                            Console.WriteLine($"Erro, no usuario {i+1}\n");
                        }
                        
                }  
                break;

                default:
                    Console.WriteLine("Voce acabou de sair do programa");
                break;
            }
        }
            
        }
    }
}

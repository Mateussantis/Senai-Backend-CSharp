using System;

namespace Aula2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String placa;
            String final;
            String resultado;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            int caracteres = placa.Length;

            final = placa.Substring(caracteres-1);
            
            if (final == "1" || final == "2") {
                resultado = "IF/ELSEE Seu rodizio é na Segunda-Feira";
            }
            else if (final == "3" || final == "4") {
                resultado = "IF/ELSEE Seu rodizio é na Terça-Feira";
            }
            else if (final == "5" || final == "6"){
                resultado = "IF/ELSEE Seu rodizio é na Quarta-Feira";
            }
            else if (final == "7" || final == "8") {
                resultado = "IF/ELSEE Seu rodizio é na Quinta-Feira";
            }
            else if (final == "9" || final == "0") {
                resultado = "IF/ELSEE Seu rodizio é na Sexta-Feira";
            }
            else {
                resultado = "IF/ELSEE Essa placa nao existe";
            }

            Console.WriteLine(resultado);

            switch (final) {
                case "1":
                    resultado = "Segunda";
                    break;
                case "2":
                    resultado = "Segunda";
                    break;
                case "3":
                    resultado = "Terça";
                    break;
                case "4":
                    resultado = "Terça";
                    break;
                case "5":
                    resultado = "Quarta";
                    break;
                case "6":
                    resultado = "Quarta";
                    break;    
                case "7":
                    resultado = "Quinta";
                    break;
                case "8":
                    resultado = "Quinta";
                    break;
                case "9":
                    resultado = "Sexta";
                    break;
                case "0": 
                    resultado = "Sexta";
                    break;
                default:
                    resultado = "Placa invalida";         
                    break;           
            }

            Console.WriteLine(resultado);

        }
    }
}

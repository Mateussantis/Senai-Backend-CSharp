using System;
using DesafioDupla.Model;
namespace DesafioDupla.Controller

{
    public class HomemdeferroController {
        HomemdeferroModel homem = new HomemdeferroModel ();
        public void Pular () {
            System.Console.WriteLine ("Você está pulando. ");
        }
        public void Voar () {
            System.Console.WriteLine ("Você está voando. ");
        }
        public void Atirar () {
            System.Console.WriteLine ("Você está atirando");
        }
        public void Lancar () {
            System.Console.WriteLine ("Você está lancando o Escudo. ");
        }
        public void Defender () {
            System.Console.WriteLine ("Você está se defendendo com o Escudo");
        }

        public void Comandos (string valor, string c) {
            string sair = "";
            while (sair != "sair") {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write ("O que deseja fazer? || Para sair do jogo, digite sair! ");
                sair = System.Console.ReadLine ();
                System.Console.Clear ();
                    if (sair == "1") {
                        Pular ();
                    } else if (sair == "2") {
                        Voar ();
                    } else if (sair == "3") {
                        Atirar ();
                    }
                    else {
                    System.Console.WriteLine ("Digite um comando válido");
                }
            }     
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Comandos (string valor) {
            string sair = "";
            while (sair != "sair") {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write ("O que deseja fazer? || Para sair do jogo, digite sair! ");
                sair = System.Console.ReadLine ();
                System.Console.Clear ();
                    if (sair == "1") {
                        Pular ();
                    } else if (sair == "2") {
                        Lancar ();
                    } else if (sair == "3") {
                        Defender ();
                    }
                    else {
                    System.Console.WriteLine ("Digite um comando válido");
                }
            }     
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
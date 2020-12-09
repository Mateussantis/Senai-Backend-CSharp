using System.Collections.Generic;
using testee.Model;
using System;
namespace testee.Controller
{
    public class TesteController
    {
        TesteModel testei = new TesteModel();
        List<TesteModel> teste = new List<TesteModel>();
        public void receber() {
            string x = "";
            while (x != "sair") {
                System.Console.Write("Digite seu Nome: ");
                testei.nome = Console.ReadLine();
                System.Console.Write("Digite um Numero: ");
                testei.numero = Console.ReadLine();
                teste.Add(new TesteModel(testei.nome, testei.numero));
                System.Console.Write("\nQuer Continuar adicionando ? || R: ");
                x = Console.ReadLine();
                System.Console.WriteLine();
            }
        }

        public void listar() {
            foreach (TesteModel p in teste) {
                System.Console.WriteLine();
                System.Console.WriteLine(p.nome);
                System.Console.WriteLine(p.numero);
                System.Console.WriteLine();
            }
        }
    }
}
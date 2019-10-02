using System;
using System.Collections.Generic;
using Exemplo1.Model;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosModel produto1 = new ProdutosModel();

            System.Console.WriteLine(produto1.nome);

            List<ProdutosModel> prod = new List<ProdutosModel>();

            prod.Add(new ProdutosModel (1, "Cenoura", "Laranja", 2.30));
            prod.Add(new ProdutosModel (2, "LAla", "Laranja", 2.30));
            prod.Add(new ProdutosModel (3, "oi", "Laranja", 2.30));
            prod.Add(new ProdutosModel (4, "batata", "Laranja", 2.30));

            foreach (ProdutosModel p in prod)
            {
                Console.WriteLine(p.numero);
                Console.WriteLine(p.nome);
                Console.WriteLine(p.descricao);
                Console.WriteLine(p.numero2);
                Console.WriteLine();
            }
            Console.WriteLine(prod[2]);
        }
    }
}

using System;
using Aula11_POO.Ex.Controlers;

namespace Aula11_POO {
    class Program {
        static void Main (string[] args) {
            #region Produto1
            ProdutosController produto1 = new ProdutosController ();
            produto1.CadastrarProduto ();
            produto1.ExibirProduto ();
            #endregion
        }
    }
}
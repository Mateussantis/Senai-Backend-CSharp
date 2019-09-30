using System;
using System.IO;
using Aula11_POO.Ex.Models;
namespace Aula11_POO.Ex.Controlers {
    public class ProdutosController {
        ProdutosModel produto = new ProdutosModel();
        public void CadastrarProduto () {
            try {
                Console.Write("Digite o Id do Produto: ");
                produto.IdProduto = int.Parse (Console.ReadLine());

                Console.Write("Digite o Nome do Produto: ");
                produto.NomeProduto = Console.ReadLine();

                Console.Write("Digite a Descrição: ");
                produto.Descricao = Console.ReadLine();

                Console.Write("Digite o Preço: ");
                produto.Preco = double.Parse(Console.ReadLine());

                // Console.Write("Digite o ID do Fornecedor");
                // produto.Fornecedor.IdFornecedor = int.Parse(Console.ReadLine());

                // Console.Write("Digite o Nome do Fornecedor: ");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine();

            } catch (Exception ex) {
                Console.WriteLine("Desculpe ): houve um erro na aplicação!");
                SalvarErros(ex);
            }
        }

        public void ExibirProduto () {
            Console.WriteLine("\nProduto");
            Console.WriteLine("Id: " +produto.IdProduto);
            Console.WriteLine("Produto: " +produto.NomeProduto);
            Console.WriteLine("Descrição: " +produto.Descricao);
            Console.WriteLine("Preço: " +produto.Preco);

            // Console.WriteLine(produto.Fornecedor.NomeFornecedor);
            // Console.WriteLine(produto.Fornecedor.IdFornecedor);
        }

        private void SalvarErros (Exception ex) {
            StreamWriter txt = new StreamWriter("error_log.txt", true);
            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();
            txt.Close ();
        }
    }
}
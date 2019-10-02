using System.Collections.Generic;
using Ex1.Model;
namespace Ex1.Controller
{
    public class PedidosController 
    {

        PedidosModel pedidos = new PedidosModel();
        List<PedidosModel> lista = new List<PedidosModel>();

        public void FazerPedidoNovo(string teste1, string teste2, string teste3, string teste4) {
            string sair = "";

            while (sair != "sair") {
                System.Console.Write("Deseja fazer mais um pedido ?");
                sair = System.Console.ReadLine();

                FazerPedido();

                lista.Add(new PedidosModel(teste1,teste2,teste3,teste4));
            }
        }

        public string FazerPedido() {
            System.Console.Write("Tipo da pizza, Doce ou Salgada: ");
            string teste1 = pedidos. = System.Console.ReadLine();

            System.Console.Write("Pizza: ");
            string teste2 = pedidos.pizza.nome = System.Console.ReadLine().ToString();

            System.Console.Write("Normal ou Grande: ");
            string teste3 = pedidos.pizza.tamanho = System.Console.ReadLine();

            System.Console.Write("Endereco de entrega: ");
            string teste4 = pedidos.endereco = System.Console.ReadLine();
            return teste1 + teste2 + teste3 + teste4;
        }

        public void LerPedido() {
            System.Console.WriteLine("\nInfos do seu pedido");
            System.Console.WriteLine(pedidos.pizza.tipo);
            System.Console.WriteLine(pedidos.pizza.nome);
            System.Console.WriteLine(pedidos.pizza.tamanho);
            System.Console.WriteLine(pedidos.pizza.preco);
        }

        public void Prever() {
            System.Console.WriteLine(pedidos.data);
            System.Console.WriteLine(pedidos.endereco);
            System.Console.WriteLine(pedidos.data.AddMinutes(30));
        }

    }
}
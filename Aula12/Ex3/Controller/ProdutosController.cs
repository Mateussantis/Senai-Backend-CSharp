using Ex3.Model;
namespace Ex3.Controller
{
    public class ProdutosController
    {
        ProdutosModel produto = new ProdutosModel();
        
        public void Reservar() {
            System.Console.Write("Deseja reservar TODOS os produto ? ");
            bool resultado = bool.Parse(System.Console.ReadLine());

            if (resultado == true) {
                System.Console.WriteLine("Voce acabou de se endividar !!!");
            }
            else {
                System.Console.WriteLine("Muito sabio!");
            }
        }
        public void cadastrar() {
            System.Console.WriteLine("Digite infos do produto: ");
            produto.nome = System.Console.ReadLine();
        }
    }
}
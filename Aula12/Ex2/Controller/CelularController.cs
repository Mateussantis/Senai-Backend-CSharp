using Ex2.Model;
namespace Ex2.Controller
{
    public class CelularController
    {
        CelularModel celular = new CelularModel();
    
        public string Ligar() {
            return "O celular esta ligado!"; 
        }
        public bool Desligar() {
            System.Console.Write("Quer Desligar o celular ? : ");
            bool valor = bool.Parse(System.Console.ReadLine());
            return valor;
        }

        public void Ligacao(bool valor) {
            if (valor == true ) {
                System.Console.WriteLine("O celular esta desligado, não é possivel fazer uma Ligação!");
            }
            else if (valor == false) {
                System.Console.WriteLine("Ligando para Senai...");
            }
        }

        public void Mensagem(bool valor) {
            if (valor == true) {
                System.Console.WriteLine("O celular esta desligado, não é possivel enviar uma Mensagem!");
            }
            else if (valor == false) {
                System.Console.WriteLine("Mandando Mensagem...");
            }
        }
    }
}
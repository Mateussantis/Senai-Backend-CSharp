using Ex4.Model;
namespace Ex4.Controller {
    public class CalculadoraController {
        CalculadoraModel calculadora = new CalculadoraModel ();

        public void Receber () {
            try {
                System.Console.Write ("Digite o primeiro Numero: ");
                calculadora.numero1 = double.Parse (System.Console.ReadLine ());

                System.Console.Write ("Digite o segundo Numero: ");
                calculadora.numero2 = double.Parse (System.Console.ReadLine ());
            } catch {
                System.Console.WriteLine ("Voce não digitou um tipo valido!");
            }
        }

        public double Somar() {
            calculadora.resultado = calculadora.numero1 + calculadora.numero2;
            return calculadora.resultado;
        }
        public double Dividir() {
            calculadora.resultado = calculadora.numero1 / calculadora.numero2;
            return calculadora.resultado;
        }
        public double Multiplicar() {
            calculadora.resultado = calculadora.numero1 * calculadora.numero2;
            return calculadora.resultado;
        }
        public double Subtrair() {
            calculadora.resultado = calculadora.numero1 - calculadora.numero2;
            return calculadora.resultado;
        }

        // public string Resultado () {
        //     double resultado = 0;
        //     string texto = "";
        //     try {
        //         if (calculadora.tipo == "soma") {
        //             resultado = calculadora.numero1 + calculadora.numero2;
        //             texto = $"O resultado foi: {resultado}";
        //         } 
        //         else if (calculadora.tipo == "multiplicação") {
        //             resultado = calculadora.numero1 * calculadora.numero2;
        //             texto = $"O resultado foi: {resultado}";
        //         }
        //          else if (calculadora.tipo == "divisão") {
        //             resultado = calculadora.numero1 / calculadora.numero2;
        //             texto = $"O resultado foi: {resultado}";
        //         }
        //         else if (calculadora.tipo == "subtração") {
        //             resultado = calculadora.numero1 - calculadora.numero2;
        //             texto = $"O resultado foi: {resultado}";
        //         }
        //     } catch {
        //         System.Console.WriteLine ("Erro, voce não digitou um tipo Valido! ");
        //     }
        //     return texto;
        // }

    }
}
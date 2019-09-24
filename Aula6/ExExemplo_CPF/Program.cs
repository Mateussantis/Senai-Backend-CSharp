using System;

namespace ExExemplo_CPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite Seu cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine(validacpf(cpf));
        }

        static bool validacpf(string cpfusuario) {

            bool resultado = false;
            int[] v1 = {10,9,8,7,6,5,4,3,2};
            string cpfcalculo = "";
            int resto = 0;
            int calculo = 0;
            string digito_v1 = "";
            string digito_v2 = "";

            cpfusuario = cpfusuario.Replace("-", "");
            cpfusuario = cpfusuario.Replace(".", "");
            cpfusuario = cpfusuario.Replace(" ", "");

            cpfcalculo = cpfusuario.Substring(0, 9);

            for (int i = 0; i <= 8; i++) {
                calculo += int.Parse(cpfcalculo[i].ToString()) * v1[i];
            }        

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9) {
                digito_v1 = "0";
            }
            else {
                digito_v1 = calculo.ToString();
            }

            if (digito_v1 == cpfusuario[9].ToString()) {
                resultado = true;
            }

            int [] v2 = {11,10,9,8,7,6,5,4,3,2};
            calculo = 0;
            resto = 0;
            cpfcalculo = cpfcalculo + calculo.ToString(); 

            for (int i = 0; i <= 9; i++) {
                calculo += int.Parse(cpfcalculo[i].ToString()) * v2[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 9) {
                digito_v2 = "0";
            }
            else {
                digito_v2 = calculo.ToString();
            }
            if (digito_v2 == cpfusuario[10].ToString()) {
                resultado = true;
            }
            return resultado;
        } 
    }
}

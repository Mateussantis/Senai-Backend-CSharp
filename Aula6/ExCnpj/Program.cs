using System;

namespace ExCnpj
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Digite Seu cnpj: ");
            string cnpj = Console.ReadLine();

            Console.WriteLine(calculoCnpj(cnpj));
        }

        static bool calculoCnpj(string cnpj) {

            int[] vetor1 = {5,4,3,2,9,8,7,6,5,4,3,2};
            string calculacnpj;
            string calculacnpj2;
            string d1 = "";
            string d2 = "";
            int resto = 0;
            int calculo = 0;
            bool resultado = false;

            cnpj = cnpj.Replace("-", "");
            cnpj = cnpj.Replace(".", "");
            cnpj = cnpj.Replace(" ", ""); 

            calculacnpj = cnpj.Substring(0, 12);           

            for (int i = 0; i <= 11; i++) {
                calculo += int.Parse(calculacnpj[i].ToString()) * vetor1[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo < 2) {
                d1 = "0";
            }
            else {
                d1 = calculo.ToString();
            }
            if (d1 == cnpj[12].ToString()){
                resultado = true;
            }
            
            int d3 = int.Parse(d1.ToString());
            int[] vetor2 = {d3,5,4,3,2,9,8,7,6,5,4,3,2};
            resto = 0;
            calculacnpj2 = cnpj.Substring(0, 12) + calculo.ToString();
            calculo = 0;

            for (int i = 0; i <= 12; i++) {
                calculo += int.Parse(calculacnpj2[i].ToString()) * vetor2[i];
            }

            resto = calculo % 11;
            calculo = resto - 11;

            if (calculo < 2) {
                d2 = "0";
            }
            else {
                d2 = calculo.ToString();
            }

            if (d2 == cnpj[13].ToString()) {
                resultado = true;
            }
            else {
                resultado = false;
            }
            return resultado;
        }
    }
}

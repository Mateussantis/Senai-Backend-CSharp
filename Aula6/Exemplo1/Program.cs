using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[3];

            Console.WriteLine();

            for (int i = 0; i <= 2; i++) {
                Console.Write($"Digite o {i+1} numero: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nA media desses valores é: " +calculamedia(valores)); 
            Console.WriteLine("A media desses valores é: " +somavalores(valores)); 
            Console.WriteLine();
        }
        
        /// <summary>
        /// Função que escreve bom dia para o usuario;
        /// </summary>
        /// <returns>Retorna, Olá, bom dia;</returns>
        static string Bomdia() {
            return "Olá. Bom Dia"; 
        }

        /// <summary>
        /// Função que retorna uma saudação de acordo com o horario
        /// </summary>
        /// <param name="saudação">De acordo com o horario</param>
        /// <returns></returns>
        static string Bomdia(string saudação) {
           int hora = DateTime.Now.Hour;

           if (hora <= 12 && hora >= 6) {
               saudação = "Bom Dia";
           }
           else if (hora > 12 && hora <= 18) {
               saudação = "Boa Tarde";
           }
           else {
               saudação = "Boa noite";
           }
            return saudação;
        }

        /// <summary>
        /// Retorna um numero
        /// </summary>
        /// <param name="numero">Inteiro qualquer</param>
        /// <returns>Numero passado como paramentro</returns>
        static int Bomdia(int numero) {
            return numero;
        }

        /// <summary>
        /// Fução que imprimi a data e a hora;
        /// </summary>
        static void ImprimiDataHora() {
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.Hour);
        }


        /// <summary>
        /// Função que calcula a media de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Media dos valores</returns>
        static double calculamedia(double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;
        }

        /// <summary>
        /// Soma os valores desse vetor
        /// </summary>
        /// <param name="valores">Vetor</param>
        /// <returns>Soma dos valores</returns>
        static double somavalores(double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }
            return resultado;
        }
    }
}

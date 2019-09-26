using System;

namespace Try_Cath
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            try {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) {
                Console.WriteLine("Erro, digite um numero!" +ex);
            }
        }
    }
}

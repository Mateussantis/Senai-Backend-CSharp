﻿using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int maior = 0;
            int indice = 0;
            for (int i = 0; i <= 9; i++) {
                Console.Write($"Digite o {i} valor:  ");
                vetor1[i] = int.Parse(Console.ReadLine());

                if (i == 0) {
                    maior = vetor1[i];
                }
                
                if (maior < vetor1[i]) {
                    maior = vetor1[i];
                    indice = i;
                }  
            }
            Console.WriteLine($"O maior valor digitado foi: {maior}, alocado no indice {indice}!!!");
        }
    }
}

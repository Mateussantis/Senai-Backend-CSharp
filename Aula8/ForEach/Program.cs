using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v1 = {"A", "B", "C", "D"};
            
            foreach (string i in v1) {
                Console.WriteLine(i);
            }
        }
    }
}

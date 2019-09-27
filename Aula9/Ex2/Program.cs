using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            dia();
        }
        static void dia() {
            DateTime dias = DateTime.Today;
            Console.WriteLine(dias.DayOfWeek);
        }
    }
}

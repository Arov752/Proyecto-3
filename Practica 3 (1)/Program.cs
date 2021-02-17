using System;

namespace Practica_3__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=1;

            while (b > 0)
            {
                Console.WriteLine("escriba un numero mayor a 0");
                b = int.Parse(Console.ReadLine());
                a = a + b;
                Console.Clear();
                Console.WriteLine(a);
            }
        }
    }
}

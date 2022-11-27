using System;

namespace Lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va calcula media aritmetica a trei numere citite de la
               tastatura */

            Console.WriteLine("Introduceti primul numar ");
            int numar1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar ");
            int numar2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar ");
            int numar3 = int.Parse(Console.ReadLine());

            int mediaAritmetica = (numar1 + numar2 + numar3) / 3;
            Console.WriteLine("Media aritmetica este: " + mediaAritmetica);
            
        }
    }
}

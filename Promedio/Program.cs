using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r=0;
            Console.WriteLine("Ingrese primer numero");
            double z=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            double x=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer numero");
            double c=double.Parse(Console.ReadLine());

            r=z + x + c;
            r=r/3;

            System.Console.WriteLine("su resultado es: " + r);
        }
    }
}
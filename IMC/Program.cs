using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //necesito la altura del cliente
            System.Console.WriteLine("Ingrese su altura");
            double altura=double.Parse(Console.ReadLine());
            //necesito el peso del cliente
            System.Console.WriteLine("Ingrese su peso");
            double peso=double.Parse(Console.ReadLine());
            //necesito calcular el IMC
            double IMC=peso/(altura*altura);
            //necesito informar al usuario su estado

            /*Interpretación del IMC
            Bajo peso: IMC menor de 18.5
            Normal: IMC entre 18.5 y 24.9
            Sobrepeso: IMC entre 25 y 29.9
            Obesidad: IMC de 30 o mayor */

            if(IMC<=18.5)
            {
                System.Console.WriteLine("Usted tiene bajo peso");
            }
            else if (IMC>=18.5 && IMC<=24.9)
            {
                System.Console.WriteLine("Ustes tiene peso normal");
            }
            else if(IMC>=25 && IMC<=29.9)
            {
                System.Console.WriteLine("Usted tiene sobre peso");
            }
            else
            {
                System.Console.WriteLine("Usted esta obeso");
            }
        }
    }
}
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esPalindromo=true;
            //Solicitar al usuario que ingrese una cadena de texto.
            System.Console.WriteLine("Ingrese una cadena de texto");
            string cadena=Console.ReadLine();
            //Eliminar espacio en blanco y convertir la cadena  a minusculas
            cadena=cadena.Replace(" ", "");
            cadena=cadena.ToLower();
            //tengo que comparar la primera letra con la ultima letra , la segunda con la ante ultimo , etc.
            for(int i=0;i<cadena.Length/2;i++)
            {
                if(cadena[i]!=cadena[cadena.Length-i-1])
                {
                    esPalindromo=false;
                    System.Console.WriteLine("No es palindromo");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
            //Mostrar en pantalla si la palabra es palindroma
            if(esPalindromo==true)
            {
                System.Console.WriteLine("Es palindromo");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
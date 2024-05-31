using System.Runtime.Intrinsics.Arm;

namespace Año_biciesto;

class Program
{
    static void Main(string[] args)
    {
        //Voy a pedir el input del usuario
        //luego voy a verificar si ingreso bien el año
        //Si el imput esta mal repite el proceso
        //Si el imput esta bien voy a llamar el metodo EsBiciesto
        bool esNumero = false;
        int añoNumero = 0;
        do
        {
            System.Console.WriteLine("Ingrese el año en el que nacio correctamente");
            string añoLetras = Console.ReadLine();
            esNumero = int.TryParse(añoLetras, out añoNumero);
        } while (!esNumero);

        if (!esNumero)
        {
            System.Console.WriteLine("Ingrese solo numeros");
        }
        if (EsBiciesto(añoNumero))
        {
            System.Console.WriteLine("Tu año es biciesto");
        }
        else
        {
            System.Console.WriteLine("Tu año no es biciesto");
            System.Console.WriteLine(
                "Queres saber cual es el siguiente año biciesto ? escribir Y para si y N para no"
            );
            string x = Console.ReadLine().ToLower();
            if (x == "y")
            {
                //agarro el numero del usuario
                //agrego un año a su numero
                //verifico si es biciesto
                //si no es biciesto repito hasta que sea biciesto
                int restos = añoNumero % 4;
                añoNumero = añoNumero + (4 - restos);
                System.Console.WriteLine(añoNumero);
            }
        }
    }

    public static bool EsBiciesto(int año)
    {
        if (año % 4 == 0)
        {
            if (año % 100 == 0)
            {
                if (año % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
        //otra forma de resolverlo
        //return (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
    }
}
/*p: Es divisible por 4
q: Es divisible por 100 (¬q entonces significa no divisible por 100)
r: Es divisible por 400
𝑝∧(¬𝑞∨𝑟)*/
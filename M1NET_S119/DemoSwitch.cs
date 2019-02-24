using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S119
{
    class DemoSwitch
    {
        static void Main(string[] args)
        {
            int opcion=0;
            string seguir = "s";
            while (seguir.Equals("s"))
            {
                Console.WriteLine("Aplicacion para adopcion de mascota");
                Console.WriteLine("Ingrese la moscota que desea adoptar");
                Console.WriteLine("1. Perro");
                Console.WriteLine("2. Gato");
                Console.WriteLine("3. Loro");
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("la mascota adoptada es Perro");
                        break;
                    case 2:
                        Console.WriteLine("La mascota adoptada es Gato");
                        break;
                    case 3:
                        Console.WriteLine("La mascota adoptada es Loro");
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida");
                        break;
                }
                Console.WriteLine("Desea continuar? (s/n)");
                seguir = Console.ReadLine().ToLower();
            }
           
            Console.ReadLine();

        }
    }
}

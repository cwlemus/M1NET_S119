using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1NET_S118;
namespace M1NET_S119
{
    class Program
    {
        //estoy haciendo uso de la clase empleado
        /*
             
        */
        Empleado empleado;
        public static int opcion;
        public int numero=0;
        public decimal moneda;

        static void Main(string[] args)
        {
            System.Console.WriteLine("Primer aplicativo en .net");
            Console.WriteLine("Inscripción al modulo 1");
            Console.WriteLine("1. Aplicaciones en .NET");
            Console.WriteLine("2. Aplicaciones en Java");

            opcion = int.Parse(Console.ReadLine());

            if (opcion==1)
            {
                Console.WriteLine("Bienvenido a Modulo 1 de .NET");
            }
            else if(opcion==2)
            {
                Console.WriteLine("Bienvenido a Modulo 1 de Java");
            }
            else
            {
                Console.WriteLine("Opcion seleccionada no es valida");
            }
            Console.ReadLine();            
        }
    }

   
}

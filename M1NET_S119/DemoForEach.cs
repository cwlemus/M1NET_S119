using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S119
{
    class DemoForEach
    {

        static void Main(string[] args)
        {
            int[] arreglo = new int[] { 0, 1, 2, 3 };
            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S119
{
    class Renta
    {
        static void Main(string[] args)
        {
            decimal salario = 1700;
            decimal salarioRenta = 0;
            if(salario>=472.01m && salario <= 895.24m)
            {

            }else
            if(salario>=895.25m && salario <= 2038.10m)
            {
                salarioRenta = salario - 895.25m;
                salarioRenta = (salarioRenta * 0.20m) + 60;
            }
            else if(salario>2038.11m)
            {

            }
            else
            {
                Console.WriteLine("Excento de renta");
            }
        }
    }
}

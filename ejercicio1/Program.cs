using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int a = 10, b = 3, c = 1, d, e;
            float x, y;

            x = a / b;

            //el operador && no se puede ultilizar dentro de una variable int, double o float
            if ((a < b) && (a < c)) {
                //en este caso se debe establecer la condicion puesta en el ejercicio
            }
            else
            {
                //en este caso deestablecer otra condicion
            }

            d = a + b++;
            e = ++a - b;
            y = (float)a / b;




        }
    }
}

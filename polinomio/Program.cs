using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polinomio
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int x;
            double respuesta;

            Console.WriteLine("ingrese el valor de x");
            x = int.Parse(Console.ReadLine());

            respuesta = (3 * x*x*x*x*x) - (5 * x * x * x ) + (2 * x) - 7;

            Console.WriteLine(respuesta);
            Console.ReadLine();
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplode5
{
    class Program
    {
        public static int index;
        static void Main(string[] args)
        {
            int mod5, mod2, a, b, inicio, fin;

            for (index = 0; index > 1; index++)
            {

                Console.Write("DIgite inicio");
                a = int.Parse((Console.ReadLine()));

                Console.Write("Digite el fin");
                b = int.Parse((Console.ReadLine()));

                operacion m = new operacion();
                Program g = new Program();

                if ((a > -1) && (b > -1))
                {
                    m.Condicion(a, b);
                }

                else
                {
                    Console.WriteLine("Digite valores postivos n");
                    index--;
                }
            }
        }
    }
}
        
    


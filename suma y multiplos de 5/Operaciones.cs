using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_y_multiplos_de_5
{
    class Operaciones
    {
        int mod5, mod2, a, b, inicio, fin;
        public void Condicion(int a, int b)
        {
            if (a < b)
            {
                inicio = a;
                fin = b;
                for (int i= inicio; i < fin;i++)
                {
                    mod5 = i % 5;
                    mod2 = i % 2;

                    if ((mod5 == 0) && (i !=0 ))
                    {
                        Console.WriteLine($"Num {i}");
                    }
                }
            }
        }
    }
}

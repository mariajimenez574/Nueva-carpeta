using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class clejer4
    {
        private double c3, c2, c1, c0;
        public clejer4 (double a, double b, double c, double d)
        {
            c3 = a;
            c2 = b;
            c1 = c;
            c0 = d;
        }

        public double valorpara (double x)
        {
            double resultado;
            resultado = c3 * x * x * x + c2 * x * x + c1 * x + c0;
            return resultado;
        }
    }
}

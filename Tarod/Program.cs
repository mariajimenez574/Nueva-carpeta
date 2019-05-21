using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el dia dde su nacimiento");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el mes de nacimiento");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el año de su nacimiento");
            int year = int.Parse(Console.ReadLine());

            if ((year <= 2019) && (mes > 0 && mes <= 12) && (dia > 0 && dia <= 31))
            {
                int suma = dia + mes + year;
                int n1, n2, res;

                int[] var = new int[8];


                var[0] = suma % 10;
                var[1] = suma / 10;
                var[2] = var[1] % 10;
                var[3] = var[1] / 10;
                var[4] = var[3] % 10;
                var[5] = var[3] / 10;

                n1 = var[0] + var[2] + var[4] + var[5];

                var[6] = n1 % 10;
                var[7] = n1 / 10;
                res = var[6] + var [7];

                Console.WriteLine($"Su numero del tarot es el {res}");

            }

            else
            {
                Console.WriteLine("Fecha de nacimiento no valida");
            }

            Console.ReadKey();
        }
    }
}

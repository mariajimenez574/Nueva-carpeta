using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluarserie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite hasta donde llegara la sumatoria");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite hasta donde iniciara la sumatoria");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite el primer coeficiente de la sumatoria");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite le termino independiente de la sumatoria ");
            int y = int.Parse(Console.ReadLine());

            if (b > a)
            {
                double sum, acum = 0;

                for (int i = a; i <= b; i++)
                {
                    sum = 1 / ((double)x + ((double)i * (double)y));
                    acum = acum + sum;

                }

                Console.Write($"El resultado de la sumatoria es:{acum}");
            }
            else
            {
                Console.WriteLine($" El valor del indice superior (fin) es menor al valor indice inferior (inicio)");
            }
            Console.ReadKey();
            }
        }
         
    }




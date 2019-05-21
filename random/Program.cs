using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pcNum = rnd.Next(1, 10);
            int num = 0;
            int i;

            Console.WriteLine("Emepecemos >:) recuerda  que es entre 1 y 10");

            for (i = 0; i < 3; i++)
            {
                Console.Write("Digite un numero");
                num = int.Parse(Console.ReadLine());
                if(num == pcNum)
                {
                    break;
                }
            }
            if ((num > 0) && (num <= 10))
            {
                if (num < pcNum)
                {
                    Console.WriteLine("Un poco más");
                }
                else if (num > pcNum)
                {
                    Console.WriteLine(" Te pasaste, un poco menos");
                }
            }
            else
            {
                Console.WriteLine(" Digita un numero entre el 1 y 10 por favor ");
                i--;
            }
            if (num == pcNum )
            {
                Console.WriteLine($"EHH eres bueno, efectivamente es {pcNum}");
            }
            else
            {
                Console.WriteLine($" Has ganado el numero era {pcNum}");
            }

            Console.ReadKey();
            }


        }
        
        

    }


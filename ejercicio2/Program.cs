using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejercicio2

            string str = "Q";
            foreach (byte b in Encoding.UTF8.GetBytes(str.ToCharArray()))
            Console.Write(b.ToString() + "\n");
            Console.ReadLine();

            string str1 = "q";
            foreach (byte b in Encoding.UTF8.GetBytes(str1.ToCharArray()))
                Console.Write(b.ToString() + "\n");
            Console.ReadLine();
        }
    }
}

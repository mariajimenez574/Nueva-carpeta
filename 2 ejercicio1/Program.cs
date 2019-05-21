using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ejercicio1
{
    class programa 
    {
        public void Main(string[] args)
        {
            float gradosC = 0;

            Console.WriteLine("Digite los grados Centigrados");
            Console.ReadLine();

            gradosC = int.Parse(Console.ReadLine());
            CApGrados grados = new CApGrados();
            Console.WriteLine(CApGrados.obtenerfahrenheit(gradosC));

            Console.ReadLine();

        }
        
    }
    
}


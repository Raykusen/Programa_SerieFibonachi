using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_SerieFibonachi
{
    class SerieFibonachi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie Fibonacci del 1 al 50:");

            int a = 0;
            int b = 1;

            while (a <= 50)
            {
                if (a > 0) // Para evitar imprimir el 0
                {
                    Console.WriteLine(a);
                }

                int temp = a;
                a = b;
                b = temp + b; // Suma para obtener el siguiente número
            }

            Console.ReadLine();
        }
    }
}

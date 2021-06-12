using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2_TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum = 0, i;
          

            for (i = 100; i > (-2); i = i- 2)
            {
                Console.WriteLine(i);

                acum = acum + i;
            }

         
            Console.WriteLine("La suma de todos los numeros es: {0}", acum);
            Console.ReadKey();


        }
    }
}

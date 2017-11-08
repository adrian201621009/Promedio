using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int cali = 1;
            int acomulador=0;
            int b=0;

            
            
            while (cali > 0)
            {
                Console.WriteLine("introduce tu calificacion");
                cali = int.Parse(Console.ReadLine());
                acomulador = acomulador + cali ;
                b = b+ 1;
            }
            int promedio;
            Console.WriteLine("la suma de tu calificacion es:" + acomulador);
            promedio = acomulador/b;

            Console.WriteLine("tu promedio es: " +  promedio);
            Console.ReadKey();
        }
       
    }
}

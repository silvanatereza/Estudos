using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circunferencia 
           double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            double area = PI * raio * raio;

            Console.WriteLine($" o resultado da soma é {area}");

             



            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class MetodosEstaticos
    {

        public class CalculadoraEstatica
        {
            public static int Somar(int a, int b)
            {
                return a + b;
            }

            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(8, 7);
            Console.WriteLine($" Resultado : {resultado}");
            Console.WriteLine(CalculadoraEstatica.Somar(2 , 2 ));

        }

        // Método static não precisar de instâcia  
        // Método NÃO static tem que ter uma instância
    }
}
    

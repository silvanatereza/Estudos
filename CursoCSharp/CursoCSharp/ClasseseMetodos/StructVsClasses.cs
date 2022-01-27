using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class StructVsClasses
    {

        public struct Sponto
        {
            public int X;
            public int Y;
        }
        public class Cponto
        {
            public int X;
            public int Y;
        }
        public static void Executar()
        {
            Sponto ponto1 = new Sponto { X = 1, Y = 3 };
            Sponto CopiPonto1 = ponto1; // Atribuição  por valor 

            ponto1.X = 3;

            Console.WriteLine($"{ponto1.X}");
            Console.WriteLine($"{CopiPonto1.X}");

            Cponto ponto2 = new Cponto { X = 2, Y = 4 };
            Cponto copiaPonto2 = ponto2; // Atribuição feita por referência
            ponto2.X = 4;

            Console.WriteLine($"{ponto2.X}");
            Console.WriteLine($"{copiaPonto2.X}");
        }
    }
}

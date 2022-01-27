using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var nu1 = 3; // atribuindo o valor da variavel 
            nu1 = 7; // mudando o valor da variavel 
            nu1 += 10; // acrescentando um valor 10 a variavel  valor vai ser 17 
            nu1 -= 3; // atribução subtrativa estou retirando  3 valor da variavel 14 
            nu1 *= 5;// atribução multiplicativa valor atual da variavel * 5 
            nu1 /= 2;// atribução divisiva varivale eta denso divido por 2 

            Console.WriteLine(nu1);

            int a = 1;
            int b = a;

            a++; // a = a + 1  incremento
            b--; // b = b - 1 decremento 

            Console.WriteLine($" {a } {b }" );


        }
    }
}

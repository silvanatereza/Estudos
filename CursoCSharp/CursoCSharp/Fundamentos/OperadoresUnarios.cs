using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var ValorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(- ValorNegativo);// quando colocamos o operador unario - ele negativa 0
                                               // número ou inverte 


            Console.WriteLine( !booleano); // negação lógiva verdade vira falso é falso vira verdadeiro    



            numero1++;// Incremento vai acrencentar mais um numero(forma pos fixada )
            Console.WriteLine(numero1);

            --numero1;// Decremento ele vai retirar um número (forma pre fixada )

            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ ==   --numero2 ); // a forma pre fixada vai ser resolvida primeiro
                                                           // que seria o -- e depois vai ser resolvido a
                                                           // forma pos fixada por tando durante
                                                           // a comparação eles vão ter o mesmo valor 
            Console.WriteLine($"{numero1} {numero2}");                                               


        }
    }
}

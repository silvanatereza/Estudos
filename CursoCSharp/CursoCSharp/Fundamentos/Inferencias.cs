using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencias
    {
        public static void Executar()
        {

            /*/ aconteceu um Inferencia o c# indentificou que seria um string por conta das "" porem não podemos
             mudar a variavel nome para outro tipo pois vai dar erro */

            var nome = " silvana ";
            // nome = 123;não podemos mudar i tipo 

            Console.WriteLine("meu nome " + nome );

            // quando criamos uma inferencia temos que dar um valor para ela de imediato
            //var idade;
            var idade = 34;
            Console.WriteLine(idade);

            int a; // declaração da variavel
            a = 9;
            int b = 34; // inicialização da variavel pois foi dado um valor a mesma 
            int soma = a + b;
            Console.WriteLine($"A soma de a + b e igual a {soma }");
        }
    }
}

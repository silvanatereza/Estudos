using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => // Action é uma função que não tem retorno 
            {
                Console.WriteLine("Lambda com c#! "); // Lambda é uma Função anônima 
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
             {
                 Random random = new Random();
                 return random.Next(1, 7);
             };

            Console.WriteLine(jogarDado());

            Func<int , string> conversorHex =  numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int , int , int , string> formatardata = (dia , mes , ano ) => 
            string.Format("{0:D2}/{1:D2}/{2:D4}" , dia , mes , ano );
            Console.WriteLine(formatardata(1 ,1 , 2019));
        }
    }
}

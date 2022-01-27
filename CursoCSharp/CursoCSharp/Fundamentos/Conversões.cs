using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversões
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro; // COLOCAMOS UM NÚMERO INTEIRO EM UM DOUBLE
                                // SEM PERDA DE INFORMAÇÃO / CONVERSÃO DE FORMA IMPLÍCITA
            
            
           Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // NESSA CASO TEM QUE SER FEITO A CONVERÇÃO
                                          // EXPLÍCITA USANDO O (INT) COLOCA O TIPO QUE VOCÊ QUER CONVERTER 

            Console.WriteLine("Nota Truncada : {0}" , notaTruncada);


            // CONVERTENDO STRING PARA UM VALOR INTEIRO 
            Console.WriteLine(" Digite sua idade : ");
            string IndadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(IndadeString);
            Console.WriteLine("Idade Inserida : {0} ", idadeInteiro);


            // OUTRA FORMA DE CONVERSÃO TryParse
            Console.WriteLine("Digite o primeiro número : ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine(" Resutado {0}", numero1);
            
            
            // OUTRA FORMA DE CONVERSÃO  
            Console.WriteLine("Digite o segundo número : ");
            int.TryParse(Console.ReadLine(), out int  numero2);
            Console.WriteLine(" Resutado {0}", numero2);
        }
    }
}

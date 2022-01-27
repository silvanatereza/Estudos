using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {

            // O resultado sempre vai dar verdade ou falso 
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida ? {0}" , nota > 10 ); // MAIOR QUE 
            Console.WriteLine(" Nota inválida ?{0}" , nota < 0.0); //  MENOR QUE 
            Console.WriteLine(" Perfeito ? {0}", nota == 10.0 ); // IGUALDADE  
            Console.WriteLine(" Tem como melhorar ? {0}", nota != 10.0); // DIFERENTE 
            Console.WriteLine(" Passou por média ? {0}" , nota >= notaDeCorte); // MAIOR OU IGUAL 
            Console.WriteLine("Recuperação ? {0}" , nota < notaDeCorte);
            Console.WriteLine("Reprovado ? {0}" , nota <= 3.0); // MENOR IGUAL 

        }
    }
}

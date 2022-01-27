using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    public class CalculadoraComum
    {
        
        public int Somar( int a , int b )
        {
            return a + b;
        }
        public int Subtrair(int a , int b) // Colocamos os nomes do métodos com letras maiúsculas 
        {
            return a - b;
        }
        public int Multiplicar( int a , int b)
        {
            return a * b;
        }

       
        
        // Todo método dentro de uma classe tem que ter assinatura única  , e essa assinatura única tem são os nomes
        // e os parâmetros 
        
    }
    internal class MetodoComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(6 , 9);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(9, 6));
            Console.WriteLine(calculadoraComum.Multiplicar(7, 6));

        }
    }
}

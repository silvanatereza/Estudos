using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolação
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = " Dell";
            double preco = 5800.00;

            // fazendo concatenação 

            Console.WriteLine(" O " + nome  +  " da marca "  +  marca +  "custa " +  preco  + "." );

            // interpolação 
            Console.WriteLine(" O{0} da marca {1} custa {2} .", nome , marca , preco );

            // outra opção 

            Console.WriteLine($" O  {nome } da marca {marca } custa {preco}");

            // INTERPOLAÇÃO 

            Console.WriteLine($"1 + 1 = { 1+ 1 } !"); // ele vai colocar o valor que foi interpretado pela a expressão
        }
    }
}

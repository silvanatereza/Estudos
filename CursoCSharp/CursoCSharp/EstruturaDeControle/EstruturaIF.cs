using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {
            bool BomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno : ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possue bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            if (entrada == "S"||  entrada == "N ")
            {
                BomComportamento=true;
            }
            if (nota >= 9.0 && BomComportamento)
            {
                Console.WriteLine("Quadro de Honra ! ");
            }
            

        }
    }
}

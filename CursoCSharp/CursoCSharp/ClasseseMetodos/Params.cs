using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] Pessoas)   // Usando a palavra reservada PARAMS podemos usar podemos
                                                                 // passar quantos parâmetros eu quiser
        {
            foreach (var pessoa in Pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }

        }

        

        public static void Executar()
        {
            Recepcionar("pedro", "manu", "geraldo");

        }
    }
}

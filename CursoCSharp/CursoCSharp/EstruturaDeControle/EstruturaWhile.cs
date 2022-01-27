using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
                Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0; 

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    Console.WriteLine("Número encontrado em {0} tentativas" , tentativas);


                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine(" Menor ... tente novamente !");
                    Console.WriteLine("Tentativas restantes : {0} " , tentativasRestantes);
                        
                }
                else
                {
                    Console.WriteLine(" Maior ... Tente Novamente !");
                    Console.WriteLine("Tentativas Restantes : {0}" , tentativasRestantes);
                }

               


            }
        }
    }
}

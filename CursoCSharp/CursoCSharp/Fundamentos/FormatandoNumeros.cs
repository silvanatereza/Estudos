using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// USANDO O TOSTRING F1 ELE VAI FAZER UM AREDONDAMENTO
            Console.WriteLine(valor.ToString("C")); // ESTOU TRANSFORMANDO UM VALOR PARA UMA
                                                    // STRING O C SEGNIFICA O TIPO DE FORMANTAÇÃO
                                                    // QUE EU QUERO USAR ELE VAI TRANSFORMA EM UM VALOR MONENTARIO


            Console.WriteLine(valor.ToString("P"));// O P É DE PRECENTUAL ELE MULTIPLICOU POR 100
                                                   // E COLOCOU O PERCENTUAL
            
            Console.WriteLine(valor.ToString("#.##"));// MOSTRA QUANTAS CASAS DECIAMAIS VOÇÊ QUER COLOCAR 


            int inteiro = 250;
            Console.WriteLine(inteiro.ToString("D10"));// ELE VAI COMPLETAR ATE O NÚMERO FICAR
                                                       // COM 10 POSIÇÕES PREENCHE 0 A ESQUERDA 
        
        
        
        }


    }
}

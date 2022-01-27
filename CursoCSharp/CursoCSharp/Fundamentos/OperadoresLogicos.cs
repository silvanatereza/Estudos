using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var ExecutouTrabalho1 = true;
            var ExecutouTrabalho2= false ;


                                              // É  SÓ VAI VOLTAR VERDADEIRA SE AS 2 OPÇÕES // FOREM VERDADEIRAS
         
            var ComprouTv50 = ExecutouTrabalho1 && ExecutouTrabalho2; // op binario 

            Console.WriteLine($"Comprou tv 50 ? {ComprouTv50}");
                                                   // OU UMAS DAS 2 TEM QUE SER VERDADEIRA                            
            var ComprouSorvete = ExecutouTrabalho1 || ExecutouTrabalho2; // op binario 
            Console.WriteLine($"Comprou sorvete ? {ComprouSorvete }");
                                              // OU EXCLUSIVO 
            var comprouTv32 = ExecutouTrabalho1 ^ ExecutouTrabalho2; // op binario 
            Console.WriteLine($"Comprou a tv 32 ? {comprouTv32}");


                                                     // NEGAÇÃO LÓGICA , INVERTE UM VALOR DE UM DETERMINADO OPERANDO 
            Console.WriteLine("Mais saudável ? {0} " , !ComprouSorvete); // op unario 




        }
    }
}

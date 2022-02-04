using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{
    internal class Sealed
    {
        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1_407_033.65;
            }
            
        }
        // Não é possivel herdar de uma classe selada 
        class Avo
        {
            public virtual bool HonraNomeFamilia()
            {
                return true;
            }
        }
        class Pai : Avo
        {
            public sealed override bool HonraNomeFamilia()
            {
                return true;
            }

        }
       
        
        

        
        public static void Executar()
        {
        SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());

     
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{
    internal class Abstract
    { // Classes abstratas não podem ser instanciadas 
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return " trim trim trim...";
            }

        }

        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return " Olá ! Meu nome é Bixby !";
            }
            
        }

        public class IPhone : Celular
        {
            public override string Assistente()
            {
                return "Olá ! Meu nome é Siri!";
            }
          
        }
        

        
        

        
        

        
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
            new Samsung()
            };

           foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{
    public class Comida
    {
        public double peso;

        public Comida(double peso)
        {
            peso = peso;
        }
        public Comida()
        {

        }
    }

    public class Feijao : Comida
    {
        public double peso;
    }
    public class Arroz : Comida
    {
        public double peso;
    }
    public class Carne : Comida
    {
        public double peso;
    }
    public class Pessoa
    {
        public double peso;

        public void Comer(Feijao feijao)
        {
            
        }
        public void Comer(Arroz arroz)
        {
        
        }
        public void Comer(Carne carne)
        {
           
        }
    }
    internal class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1= new Feijao();
            ingrediente1.peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($" Agora o peso do cliente é {cliente.peso} kg !");

        }

        
    }
}

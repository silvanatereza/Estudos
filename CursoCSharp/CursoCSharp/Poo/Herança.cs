using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int VelocidadeMaxima)
        {
            VelocidadeMaxima = VelocidadeMaxima;
        }
        protected int AlteraVelocidade(int delta)

        {
            int novaVelocidade = VelocidadeAtual + delta;
             
            if(novaVelocidade < 0) 
            {
                VelocidadeAtual = 0;
            } else if(novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public  virtual int Acelerar()
        {
            return AlteraVelocidade(5);
        }
        public int Frear()
        {
           return  AlteraVelocidade(-5);
        }
    }
    
    public class Uno : Carro
    {
      public Uno() : base(200)
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

         public override int Acelerar()
        {
            return AlteraVelocidade(15);
        }
        // ocuta o método da classe pai 

        public new int Frear()
        {
            return AlteraVelocidade(-15);

            
        }
    }



    internal class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno ... ");
            Uno carr1 = new Uno();
            Console.WriteLine(carr1.Acelerar());
            Console.WriteLine(carr1.Acelerar());
            Console.WriteLine(carr1.Frear());
            Console.WriteLine(carr1.Frear());

            Console.WriteLine("Ferrari... ");
            Ferrari carr2 = new Ferrari();
            Console.WriteLine(carr2.Acelerar());
            Console.WriteLine(carr2.Acelerar());
            Console.WriteLine(carr2.Frear());
            Console.WriteLine(carr2.Frear());

            Console.WriteLine("Ferrari com tipo de carro...");
            Carro carro3 = new Ferrari(); 
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());


            carro3 = new Uno();// polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

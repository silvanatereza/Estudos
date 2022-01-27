using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class Props
    {

        public class CarroOpcional
        {
            double desconto = 0.1;// mesmo sem a palavra private ele continua sendo atributo privado 
            string nome;
            public string Nome
            {
                get { return " opcional: " + nome; }
                set { nome = value; }
            }
            // propriedades autoimplementada 
            public double preco { get; set; }

            // somente leitura 

            public double PrecoComDesconto
            {
               get => preco - (desconto * preco); // lambda 

               // get
               // {
                //    return (desconto * preco);
               // }
            }
            public CarroOpcional()
            {

            }
            public CarroOpcional( string nome , double preco )
            {
                this.Nome = nome;
                preco = preco;
            }
            

            
        }
        public static void Executar()
        {
            var op1 = new CarroOpcional(" ar condicionado ", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "direção eletrica ";
            op2.preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.preco);


            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.preco);
            Console.WriteLine(op2.PrecoComDesconto);

        }
    }
}

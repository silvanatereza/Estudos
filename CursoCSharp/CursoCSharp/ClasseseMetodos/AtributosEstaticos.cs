using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class AtributosEstaticos
    {
        public class Produto
        {
             public string Nome;
            public double  Preco;
            public static double Desconto = 0.1; // atributo statc , pode ser instânciado 
            public Produto( string nome ,  double preco , double desconto) // construtor com 3 parâmetros 
            {
                Nome = nome;
                preco = preco;
                Desconto = desconto;
                
            }
            public Produto() // construtor vazio 
            {

            }
            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }
        public static void Executar()
        {
            var Produto1 = new Produto("caneta", 3.2,0.1 );

            var Produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 4.9,
               

            };

            Produto.Desconto = 0.5; // todos os produtos que estão na classe vão receber o desconto 

            Console.WriteLine($"Preço com desconto : {Produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto : {Produto2.CalcularDesconto()}");

            Produto.Desconto = 0.02;

            Console.WriteLine($"Preço com desconto : {Produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto : {Produto2.CalcularDesconto()}");

        }
    }
}

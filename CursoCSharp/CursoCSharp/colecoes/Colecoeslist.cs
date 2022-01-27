using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.colecoes
{
    internal class Colecoeslist
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome , double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var livro = new Produto(" Game of Throne", 49.9);

            var carrinho = new List<Produto>(); /// Dentro do <> colocamos o tipo de dados que queremos aramazenar 
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("camisa", 29.90),
                new Produto("8° Temporada Gme of Thrones " , 99.9),
                new Produto("Poster" , 10)
            };
            carrinho.AddRange(combo); // usando o AddRange para adicionar o conteúdo de uma lista dentro de outra 

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3); // removendo o elemento do indice 3 

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}

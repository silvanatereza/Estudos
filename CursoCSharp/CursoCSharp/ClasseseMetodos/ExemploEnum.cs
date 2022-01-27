using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class ExemploEnum
    {
        public enum Genero { Acao , Aventura , Terror , Animacao , Comedia };

        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Animacao; // conversão de um enum para um inteiro 

            Console.WriteLine(id);

            var FilmeParaFamilia = new Filme();
            FilmeParaFamilia.Titulo = "Sharknardo 17 ";
            FilmeParaFamilia.GeneroDoFilme = Genero.Comedia; // atribuindo um enum 

            Console.WriteLine($"{FilmeParaFamilia.Titulo} , {FilmeParaFamilia.GeneroDoFilme}");

        }
    }
}

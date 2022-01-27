using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class Membros
    {
        public static void Executar()
        {

            /* Criando um objeto */
            //tipo //nome //    construtor//
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "silvana ";
            sicrano.Idade = 33;

            //Console.WriteLine($"o nome de sicrano é {sicrano.Nome} é a idade de sicrano é {sicrano.Idade}");//


            sicrano.ApresentarNoConsole();

        }
    }
}

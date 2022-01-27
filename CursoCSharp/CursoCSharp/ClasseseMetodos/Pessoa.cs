using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class Pessoa
    {
        // Atributos 
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"olá me chamo {Nome} e tenho {Idade} anos ");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}

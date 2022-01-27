using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{
    internal class Readonly
    {
        public class Cliente
        {
            public string Nome;
             readonly DateTime Nascimento; // Readonly é um valor imutável  somente para leitura 

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }
            public string GetDataDeNascimento()
            {
                return string.Format("{0}/{1}/{2}" , Nascimento.Day, Nascimento.Month, Nascimento.Year);// FORMATAR A DATA DE
                                                                                                        // NASCIMENTO
            }



        }
        public static void Executar()
        {
            var novoCliente = new Cliente("silvana tereza ", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
            

        }

        
    }
}

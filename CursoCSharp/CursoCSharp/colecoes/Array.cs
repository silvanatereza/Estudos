using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Roberto";
            alunos[1] = "Claudia";
            alunos[2] = "Juliana";
            alunos[3] = " Karla";
            alunos[4] = "Renato";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double Somatorio = 0;
            double[] notas = { 7.7, 7.9, 4.0, 9.0, 2.6 };

            foreach (var nota in notas)
            {
                Somatorio += nota; 
            }
            double media = Somatorio / notas.Length;
            Console.WriteLine(media );

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    } 
}

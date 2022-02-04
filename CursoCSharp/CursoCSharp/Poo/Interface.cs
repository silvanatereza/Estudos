using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{
    
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria
    {
        public int Operacao(int a , int b)
        {
            return a + b;
        }
    }
    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a , int b)
        {
            return a- b;
        }
    }
    class multiplicacao: OperacaoBinaria
    {
        public int Operacao( int a , int b)
        {
            return a * b; 
        }
    }
    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new multiplicacao(),
        };

        public string ExecutarOperacoes(int a , int b)
        {
            string Resultado = " ";

            foreach (var op in operacoes)
            {
                Resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)} \n";
            }
            return Resultado;
        }
    }
    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);


        }
    }
}

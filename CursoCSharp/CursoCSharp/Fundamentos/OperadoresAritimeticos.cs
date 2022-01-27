﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // preço com desconto 
            var preco = 1000; // double
            var imposto = 350; // inteiro 
            var desconto = 0.1;

            double total = preco + imposto;// operação de soma 

            var totalComDesconto = total - total * desconto; // operação de multiplicação e subtração 

            Console.WriteLine($" o preço final é : {totalComDesconto}");

            // IMC 

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow (altura , 2 ); // peso dividido pela a altuta ao quadrado 

            Console.WriteLine($" o valor do IMC  é : {imc}");

            // NÚMERO PAR/IMPAR USANDO O MÓDULO (resto da divisão )

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/ tem resto {1}" , par , par % 2);
            Console.WriteLine("{0}/ 2 tem o resto {1}" , impar , impar % 2 );

        }
    }
}

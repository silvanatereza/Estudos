using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write(" Qual é o seu nome ? ");
            string Nome = Console.ReadLine();// o resultado do que for digitado vai ser armazenado em Nome 

            Console.Write(" Qual é a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            // por padrão tudo que for escrito vai voltar  como uma string então temos que converter , 
            //´para converter usamos o tipo que damos a variavel e o .Parse 
            // ex nt idade = int.Parse(Console.ReadLine());
            
            
            Console.Write("Qual é o seu salário ? ");
           
            
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //  sempre que for usar o ponto como separador de casas dessimais temo que usar o
            //  CultureInfo.InvariantCulture e o using System.Globalization;


            Console.WriteLine($"Meu nome é : {Nome } e tenho {idade } anos e o meu salário é r$: {salario}");



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{   
    public class carro
    {
        public string Modelo;
        public string Fabricante;
        public  int  Ano;

        // construtor 
        public carro(string modelo , string fabricante , int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;

        }
        public carro()
        {

        }
    }
    public  class Construtores
    {
        public static void Executar()
        {
            var carr1 = new carro();
            carr1.Modelo = "argo";
            carr1.Fabricante = "fiat";
            carr1.Ano = 2017;
            Console.WriteLine($"{carr1.Fabricante} {carr1.Modelo} {carr1.Ano}");

            var carro2 = new carro("punto" ,  "fiat" , 2017 );
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{

     interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }
      struct Coordenada : Ponto 
    {
        public int X; // atributos 
        public int Y;
        public Coordenada(int x , int y) // construtor 
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta) // métodos 
        {
            X += delta;
            Y += delta;
        }
    }
    

    
    
        
       
    
    internal class  ExemploStruct
    {
        public static void Executar()
        {
            Coordenada CoordenadaInicial;
            CoordenadaInicial.X = 2;
            CoordenadaInicial.Y = 2;

            Console.WriteLine(" Coordenada Inicial : ");
            Console.WriteLine($"{CoordenadaInicial.X}");
            Console.WriteLine($"{CoordenadaInicial.Y}");

            var CoordenadaFinal = new Coordenada(x:9, y:1);
            CoordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final :");
            Console.WriteLine($"{CoordenadaFinal.X}");
            Console.WriteLine($"{CoordenadaFinal.Y}");
        }
    }
}

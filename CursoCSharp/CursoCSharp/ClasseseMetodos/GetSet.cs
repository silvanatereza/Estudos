using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClasseseMetodos
{


    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca , string modelo , int cilindrada)  // 1° construtor 
        {
            Marca = marca;
            Modelo=modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {
            // 2° construtor padrão 
        }

        public string GetMarca()
        {
            return Marca; // retorna o valor da marca
        }
        public  void SetMarca( string marca )
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo( string modelo )
        {
            Modelo = modelo;
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada( int cilindrada)
        {
            if (Cilindrada > 0)
            {
                Cilindrada = cilindrada;
            }
            
        }



    }
    
    
    
    internal class GetSet
    {

      public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("HONDA");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);

            Console.WriteLine(moto2.GetMarca() +  " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            
        }

    }
}

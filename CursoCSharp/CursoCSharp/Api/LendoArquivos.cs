﻿using System;
using System.IO;

namespace CursoCSharp.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("caneta bic preta ; 3.5;89");
                    sw.WriteLine("bocharra branca ; 2.89 ; 27 ");
                }



            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}

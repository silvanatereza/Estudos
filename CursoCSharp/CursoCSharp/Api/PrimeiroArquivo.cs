using System;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExetensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~" , home );   
        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro arquivo .txt ".ParseHome(); // path caminhos suando o ~ para dizer que a paste home esta logada no sistema
                                                    
            if (!File.Exists(path))
            {
                using (StreamWriter sw =  File.CreateText(path))
                {
                    sw.WriteLine(" Esse é ");
                    sw.WriteLine(" O nosso ");
                    sw.WriteLine("Primeiro "); 
                    sw.WriteLine("Arquivo");
                }
            }

        }
}

    }


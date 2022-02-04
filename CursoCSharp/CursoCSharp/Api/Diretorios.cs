using System;
using System.IO;


namespace CursoCSharp.Api
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PataCSharp".ParseHome();
            var novoDiretorioDistino = @"~/PataCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDiretorioDistino))
            {
                Directory.Delete(novoDiretorioDistino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("========= PASTAS ======= ");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach (var pasta in pastas)
            {
                Console.WriteLine(pastas);
            }
            Console.WriteLine("/n/n== Arquivos ============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CursoCSharp.API {
    class Diretorios {
    public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharp/Destino".ParseHome();
            var dirProjeto = @"~/Documents/CSharp completo/CursoCSharp/CSharp-completo".ParseHome(); 

            if(Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("====PASTAS=====");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach(var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivo =====");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n==== RAIZ =====");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }

    }

}

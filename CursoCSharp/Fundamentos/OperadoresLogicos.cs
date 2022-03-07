using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var executouOTrabalho1 = false;
            var executouOTrabalho2 = false;

            var comprouTv50 = executouOTrabalho1 && executouOTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0} ", comprouTv50);

            var comprouSorvete = executouOTrabalho1 || executouOTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var ComprouTv32 = executouOTrabalho1 ^ executouOTrabalho2;
            Console.WriteLine("Comprou Tv 32? {0} ", ComprouTv32);

            Console.WriteLine("Mais saudável? {0} ", !comprouSorvete);
        }
    }
}

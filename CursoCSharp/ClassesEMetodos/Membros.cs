using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa beltrano = new Pessoa();
            beltrano.Nome = "Renato";
            beltrano.Idade = 21;
            Console.WriteLine($"{beltrano.Nome} tem {beltrano.Idade} anos.");

            beltrano.ApresentarNoConsole();
            beltrano.Zerar();
            beltrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Maria";
            fulano.Idade = -1;
            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}

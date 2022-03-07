using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome; //Valor padrão null
        public int Idade; //Valor padrão 0

        public string Apresentar() {
            return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");

        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}

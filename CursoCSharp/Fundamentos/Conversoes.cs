using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida {0}",idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Idade Inserida {idadeInteiro}");

            Console.WriteLine("Digite o primeiro número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado {numero}");

            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado {numero2}");

            Console.WriteLine(numero == numero2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class DesafioAtributo {
        int a = 10*2;
        public static void Executar() {
            //Acessar a variável 'a' dentro do método executar
            var numero = new DesafioAtributo();
            Console.WriteLine(numero.a);
        }
    }
}

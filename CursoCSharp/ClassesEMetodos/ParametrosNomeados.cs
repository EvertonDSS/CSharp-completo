using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Formata {
        int Dia;
        int Mes;
        int Ano;
        public Formata(int dia, int mes, int ano) {
            Dia = dia;
            Mes = mes;
            Ano = ano;
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);

        }

    }
    internal class ParametrosNomeados {

        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar() {
            Formatar(mes: 1, dia:21, ano:1996);
            var formatar = new Formata(mes: 12, dia:14, ano:1997);
        }
    }
}

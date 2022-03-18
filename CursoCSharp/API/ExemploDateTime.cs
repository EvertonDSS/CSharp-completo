
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API {
    class ExemploDateTime {
        public static void Executar() {
            var datetime = new DateTime(year: 2020, day: 2, month: 6);
            Console.WriteLine(datetime.Month);

            //Sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: {0}",diaAtual.Hour);
            Console.WriteLine("Minutos: {0}",diaAtual.Minute);
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}

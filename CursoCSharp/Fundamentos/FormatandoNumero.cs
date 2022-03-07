﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            

            double valor = 15.165;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));
            CultureInfo ci = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", ci));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

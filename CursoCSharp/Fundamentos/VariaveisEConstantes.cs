using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * (Math.Pow(raio,2));

            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDegols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDegols);
            saldoDegols = sbyte.MaxValue;
            Console.WriteLine(saldoDegols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileirao = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileirao);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valoDeMercadoDaApple = 1_000_000_000_000_000; //Mais usado
            Console.WriteLine("Valor Apple " + valoDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b'; //1 letra usa-se aspas simples
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);

        }
    }
}

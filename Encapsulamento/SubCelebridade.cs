using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class SubCelebridade
    {
        //Todos 
        public string InfoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto(Assembly)
        internal ulong NumeroCelular = 551199999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe ou Herança no mesmo projeto (C# >= 7.2
        private protected string SegredoFamilia = "Bla Bla Bla";

        //Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
            

        }

    }
}

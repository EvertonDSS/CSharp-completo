using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            dynamic meuObjeto = "teste";
            Console.WriteLine(meuObjeto.GetType());

            meuObjeto = 3;
            Console.WriteLine(meuObjeto.GetType());
            meuObjeto++;

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Maria Julia";
            aluno.Nota = 8.9;
            aluno.Idade = 24;

            Console.WriteLine("{0} {1} {2}", aluno.Nome, aluno.Nota, aluno.Idade);
        }
    }
}

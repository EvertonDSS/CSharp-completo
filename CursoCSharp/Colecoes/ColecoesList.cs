using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
        }
    }
}

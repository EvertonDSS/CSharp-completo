using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    internal class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa",29.9),
                new Produto("8a Temporada GoT",99.9),
                new Produto("Poster", 10)
        };
            carrinho.UnionWith(combo); //Adiciona multiplo elementos
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); //Remove elemento pelo index

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine(" {0} {1}", item.Nome, item.Preco);
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}

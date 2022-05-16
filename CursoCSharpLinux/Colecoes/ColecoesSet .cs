using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.UsandoList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {


        public static void Executar()
        {
            var livro1 = new Produto("Harry Potter", 49.9);
            var livro2 = new Produto("Crepúsculo", 49.9);
            var livro3 = new Produto("Anne Frank", 49.9);
            var livro4 = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro1);
            carrinho.Add(livro2);
            carrinho.Add(livro3);
            carrinho.Add(livro4);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("Calça", 69.90),
                new Produto("Sutiã", 19.90)
            };

            carrinho.UnionWith(combo);

            Console.WriteLine("QTD: " + carrinho.Count);

            carrinho.Add(livro1);

            Console.WriteLine("QTD: " + carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.WriteLine(item.Nome + ", " + item.Preco);
            }


        }

    }

}
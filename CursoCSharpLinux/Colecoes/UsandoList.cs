using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoList
    {

        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Executar()
        {
            var livro1 = new Produto("Harry Potter", 49.9);
            var livro2 = new Produto("Crepúsculo", 49.9);
            var livro3 = new Produto("Anne Frank", 49.9);
            var livro4 = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();

            carrinho.Add(livro1);
            carrinho.Add(livro2);
            carrinho.Add(livro3);
            carrinho.Add(livro4);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("Calça", 69.90),
                new Produto("Sutiã", 19.90)
            };

            carrinho.AddRange(combo);

            Console.WriteLine("QTD: " + carrinho.Count);

            carrinho.RemoveAt(3);

            Console.WriteLine("QTD: " + carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item) + " - ");
                Console.WriteLine(item.Nome + ", " + item.Preco);
            }


        }
    }
}

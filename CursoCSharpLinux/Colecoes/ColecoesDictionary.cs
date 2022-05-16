using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(1, "Spider Man");
            filmes.Add(2, "Super Man");
            filmes.Add(3, "Bat Man");
            filmes.Add(4, "Iron Man");
            filmes.Add(5, "X Men");

            int chave = 4;
            if (filmes.ContainsKey(chave))
            {
                Console.WriteLine(chave + ": " + filmes[chave]);
            }

            chave = 2;
            if (filmes.ContainsKey(chave))
            {
                Console.WriteLine(chave + ": " + filmes[chave]);
            }

            chave = 6;
            if (filmes.ContainsKey(chave))
            {
                Console.WriteLine(chave + ": " + filmes[chave]);
            }

            /*
            chave = 3;
            var tixe = "Bosta";

            if (filmes.TryGetValue(chave, out tixe))
            {
                Console.WriteLine(chave + ": " + filmes[chave]);
            }
            */

            Console.WriteLine(filmes.ContainsValue("Spider Man"));
            Console.WriteLine(filmes.ContainsKey(8));

            foreach (var item in filmes.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in filmes.Values)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine(filme.Value + " é de " + filme.Key);
            }


        }
    }
}

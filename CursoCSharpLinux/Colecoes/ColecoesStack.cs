using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push("Andreia");
            pilha.Push("Carol");
            pilha.Push("Samanta");
            pilha.Push("Ingrid");

            foreach(var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            pilha.Pop();

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            pilha.Pop();

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            Console.WriteLine(pilha.Peek());

            foreach (var item in pilha)

            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

        }
    }
}

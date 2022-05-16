using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Sara");
            fila.Enqueue("Jênifer");
            fila.Enqueue("Juliana");
            fila.Enqueue("Daiane");
            fila.Enqueue("Aline");
            fila.Enqueue("Estéfany");
            fila.Enqueue("Alexia");
            fila.Enqueue("Sidnéia");
            fila.Enqueue("Fernanda");
            fila.Enqueue("Ingrid");
            fila.Enqueue("Miriam");
            fila.Enqueue("Luiza Lovatto");
            fila.Enqueue("Luiza Ribeiro");
            fila.Enqueue("Eliana");
            fila.Enqueue("Daiana");
            fila.Enqueue("Patrícia");
            fila.Enqueue("Etiane");
            fila.Enqueue("Joenvillense");
            fila.Enqueue("Marília");
            fila.Enqueue("Renata");
            fila.Enqueue("Valéria");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            fila.Dequeue();

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();

            salada.Enqueue("Tomate");
            salada.Enqueue("Alface");
            salada.Enqueue("Radicci");
            salada.Enqueue("Vinagre");

            Console.WriteLine(salada.Contains("tomate"));
            Console.WriteLine(salada.Contains("Tomate"));
        }
    }
}
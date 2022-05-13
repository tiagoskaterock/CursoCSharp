using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            string[] pessoas = new string[5];
            
            pessoas[0] = "Maria";
            pessoas[1] = "Marcos";
            pessoas[2] = "Pedro";
            pessoas[3] = "Paulo";
            pessoas[4] = "Ana";

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine(pessoas[i]);
            }
        }
    }
}

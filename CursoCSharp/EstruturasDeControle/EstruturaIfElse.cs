using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            int idade = 9;
            if (idade >= 18)
            {
                Console.WriteLine("Maior de Idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}

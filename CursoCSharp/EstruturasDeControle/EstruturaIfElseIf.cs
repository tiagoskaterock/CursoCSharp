using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {

        public static void Executar()
        {
            int idade = 29;
            if (idade < 13)
            {
                Console.WriteLine("Criança");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else
            {
                Console.WriteLine("Adulto");
            }
        }

    }
}

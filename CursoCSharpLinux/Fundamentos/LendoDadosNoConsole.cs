using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDadosNoConsole
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá , " + nome + "!");
        }
    }
}

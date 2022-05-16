using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i >= 7)
                {
                    Console.WriteLine("Usando Break");
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}

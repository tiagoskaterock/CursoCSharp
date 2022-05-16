using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoArray
    {
        public static void Executar()
        {
            string[] pessoas = new string[5];

            pessoas[0] = "Ana";
            pessoas[1] = "Ingrid";
            pessoas[2] = "Luane";
            pessoas[3] = "Carla";
            pessoas[4] = "Joana";

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine(pessoas[i]);
            }
        }
    }
}

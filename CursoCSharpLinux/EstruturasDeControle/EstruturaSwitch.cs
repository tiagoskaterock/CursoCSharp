using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            int movie_rating = 15;

            switch (movie_rating)
            {
                case 10:
                    Console.WriteLine("Infantil");
                    break;
                case 13:
                    Console.WriteLine("Juvenil");
                    break;
                case 18:
                    Console.WriteLine("Adulto");
                    break;
                default:
                    Console.WriteLine("Não Definido");
                    break;
            }
        }
    }
}

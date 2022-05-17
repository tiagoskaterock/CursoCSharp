using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um Instagram!";

        // herença
        protected string CorDosOlhos = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 5554999999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Muitas gírias";

        // mesma classe ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "A Ritinha tem muitos amantes";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("...Subcelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
}

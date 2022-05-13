using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{    

    public class Membro
    {

        static void Executar()
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Tiago";
            pessoa.Idade = 37;

            Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos.");

            pessoa.ApresentarNoConsole();
        }

    }
}

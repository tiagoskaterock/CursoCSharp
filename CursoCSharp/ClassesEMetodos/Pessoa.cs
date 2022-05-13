using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {

        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return "Olá! Sou " + this.Nome + " e tenho " + this.Idade + " anos.";
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }


    }

}
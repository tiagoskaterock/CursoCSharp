using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            double nota = 5;

            string resultado = nota >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}

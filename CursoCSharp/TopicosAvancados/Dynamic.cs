using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
        }
    }
}

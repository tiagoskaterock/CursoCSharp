﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num1: " + num1);
            }
            else
            {
                Console.WriteLine("A variável num1 não possui valor");
            }

            int valor = num1 ?? 1000;

            Console.WriteLine(valor);

            bool? booleana = null;

            bool resultado = booleana.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }
    }
}

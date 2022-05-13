using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"If - Estruturas de Controle", EstruturaIf.Executar},
                {"For - Estruturas de Controle", EstruturaFor.Executar},
                {"While - Estruturas de Controle", EstruturaWhile.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
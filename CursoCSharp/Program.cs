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
                {"If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"If Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"For - Estruturas de Controle", EstruturaFor.Executar},
                {"While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
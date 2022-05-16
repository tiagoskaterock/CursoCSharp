﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.ExplorandoAPI;
using CursoCSharp.MetodosEFuncoes;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // FUNDAMENTOS
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Lendo Dados no Console - Fundamentos", LendoDadosNoConsole.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // ESTRUTURAS DE CONTROLE
                {"If - Estruturas de Controle", EstruturaIf.Executar},
                {"If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"If Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"For - Estruturas de Controle", EstruturaFor.Executar},
                {"While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // CLASSES E MÉTODOS
                {"Membros: Atributos e Métodos - Classes e Métodos", Membros.Executar},

                // COLEÇÕES
                {"Array - Coleções", UsandoArray.Executar},
                {"List - Coleções", UsandoList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},

                // OO
                {"Herança- Orientação a Objetos", Heranca.Executar},
                {"Construtor: Usando o this - Orientação a Objetos", ConstrutorThis.Executar},

                // MÉTODOS E FUNÇÕES
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},

                // EXCEÇÔES
                // seção de exceções

                // EXPLORANDO API
                {"Arquivo: Escrevendo Dados - Explorando API", ArquivoEscrevendoDados.Executar},

                

            });

            central.SelecionarEExecutar();
        }
    }
}
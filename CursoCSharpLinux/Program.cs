using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.ExplorandoAPI;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.TopicosAvancados;
using CursoCSharp.Excecoes;

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
                {"Construtores - Classes e Métodos", Construtores.Executar},

                // COLEÇÕES
                {"Array - Coleções", UsandoArray.Executar},
                {"List - Coleções", UsandoList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                {"Herança- Orientação a Objetos", Heranca.Executar},
                {"Construtor: Usando o this - Orientação a Objetos", ConstrutorThis.Executar},

                // MÉTODOS E FUNÇÕES
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Exemplo Lambda Delegate - Métodos e Funções", LambdaDelegate.Executar},

                // EXCEÇÔES                
                {"Exceção 1 - Exceções", PrimeiraExcecao.Executar},
                {"Exceção 2 - Exceções", SegundaExcecao.Executar},

                // EXPLORANDO API
                {"Arquivo: Escrevendo Dados - Explorando API", ArquivoEscrevendoDados.Executar},

                // TÓPICOS AVANÇADOS
                {"Linq 1 - Tópicos Avançados", Linq1.Executar},
                {"Linq 2 - Tópicos Avançados", Linq2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamic - Tópicos Avançados", Dynamic.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}
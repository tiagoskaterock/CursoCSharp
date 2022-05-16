using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }   

    class Linq1
    {

        public static void Executar()
        {
            var alunos = new List<Aluno>
        {
            new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
            new Aluno() {Nome = "Andre", Idade = 22, Nota = 4.3},
            new Aluno() {Nome = "Ana", Idade = 28, Nota = 9.8},
            new Aluno() {Nome = "Jorge", Idade = 21, Nota = 7.9},
            new Aluno() {Nome = "Maria", Idade = 22, Nota = 3.7},
            new Aluno() {Nome = "Julia", Idade = 29, Nota = 8.1},
            new Aluno() {Nome = "Marcia", Idade = 34, Nota = 10.0},
        };

            Console.WriteLine("--- Aprovados ---");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome + ": " + aluno.Nota);
            }

            Console.WriteLine("--- Reprovados---");
            var reprovados = alunos.Where(a => a.Nota < 7).OrderBy(a => a.Nome);
            foreach (var aluno in reprovados)
            {
                Console.WriteLine(aluno.Nome + ": " + aluno.Nota);

            }

            Console.WriteLine("--- Chamada---");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);

            }

            Console.WriteLine("--- Aprovados por Idade---");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}

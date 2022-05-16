using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class Linq2
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
                new Aluno() {Nome = "Ana", Idade = 22, Nota = 9.1},
                new Aluno() {Nome = "Marcia", Idade = 34, Nota = 10.0},
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));

            Console.WriteLine(pedro.Nome + ", " + pedro.Nota);

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));

            Console.WriteLine(fulano);

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));

            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals(4.32));

            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }
            else
            {
                Console.WriteLine(sicrano.Nome);
            }

            var ultimaAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));

            if (ultimaAna == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }
            else
            {
                Console.WriteLine(ultimaAna.Nome + ": " + ultimaAna.Nota);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine("maior: " + maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine("menor: " + menorNota);

            var soma = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(soma);

            var media = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(media);

            var mediaAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaAprovados);

            var mediaReprovados = alunos.Where(a => a.Nota < 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaReprovados);
        }

    }

}
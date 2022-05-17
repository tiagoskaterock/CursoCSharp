using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{    
    public class Carro 
    {
        public string Modelo;
        public int Ano;
        public string Montadora;

        public Carro() { }

        public Carro(string modelo, int ano, string montadora)
        {
            Modelo = modelo;
            Ano = ano;
            Montadora = montadora;
        }

        public string ToString() {
            return Montadora + " " + Modelo + " " + Ano;
        }
    }

    public class Construtores
    {

        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Ano = 1990;
            carro1.Modelo = "Uno";
            carro1.Montadora = "Fiat";

            Console.WriteLine(carro1.ToString());

            Carro carro2 = new Carro("NIssan", 2002, "Skyline");

            Console.WriteLine(carro2.ToString());

            Carro carro3 = new Carro() {
                Modelo = "Chevette",
                Montadora = "Chevrollet",
                Ano = 1975
            };

            Console.WriteLine(carro3.ToString());

        }

    }
}

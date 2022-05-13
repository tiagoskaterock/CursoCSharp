using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{

    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            Console.WriteLine("acelerar");
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            Console.WriteLine("frear");
            return AlterarVelocidade(-5);
        }
    } // FIM DE CLASSE CARRO


    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }


    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            Console.WriteLine("acelerar mais");
            return AlterarVelocidade(15);
        }

        // OCULTA O MÉTODO DA CLASSE PAI
        public new int Frear()
        {
            Console.WriteLine("frear mais");
            return AlterarVelocidade(-30);
        }
    }


    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());



            Console.WriteLine("Ferrari...");
            Ferrari ferrari1 = new Ferrari();
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Acelerar());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());
            Console.WriteLine(ferrari1.Frear());


        }
    } // FIM DE CLASSE HERANCA
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{

    public class Conta
    {
        private double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                conta.sacar(10000);
                Console.WriteLine("Retirada com sucesso");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }
        }
    }
}

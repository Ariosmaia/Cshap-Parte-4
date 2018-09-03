using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Metodo();

            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
                Console.WriteLine("Excecção tratada.");
            }

            Console.ReadLine();
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);

            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
                Console.WriteLine("Excecção tratada.");
            }
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}

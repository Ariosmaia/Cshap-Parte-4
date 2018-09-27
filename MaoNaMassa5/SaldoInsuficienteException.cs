using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassa4
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get;}
        public double ValorSaque { get;}

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassa5
{
    class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string message) : base(message)
        {
        }

        public OperacaoFinanceiraException(string message, Exception excecaoInterna) : base(message, excecaoInterna)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_OO
{
    public class ContaGenerica
    {
        public string? Banco { get; set; }
        public int Conta { get; set; }

        public int Agencia { get; set; }

        public decimal Saldo { get; set; }

        public decimal Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            return Saldo;
        }
        public virtual decimal Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
            }
            return Saldo;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_OO
{
    public class ContaCorrente : ContaGenerica
    {
        public decimal Limite { get; set; } = 0.0m;
        public override decimal Sacar(decimal valor)
        {
            if (valor > 0 && valor <= (Saldo + Limite))
            {
                Saldo -= valor;
            }
            return Saldo;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo:C}, Limite: {Limite:C}");
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_OO
{
    internal class produto
    {
        public required string nome { get; set; }
        public decimal preco { get; set; }

        public int estoque { get; set; }
        public int codigo { get; set; }

        public decimal valorestoque()
        {
            return preco * estoque;
        }
    }
};

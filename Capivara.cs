﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_OO
{

    public class Capivara() : Animal("Capivara")
    {
        public override void EmitirSom()
        {
            Console.WriteLine("A capivara faz: *silêncio elegante*");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_OO

{
    public class Livro
    {
        public required string Título { get; set; }
        public required string Autor { get; set; }
        public required string Editora { get; set; }
        public int AnoDeLancamento { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_OO
{
    public class Funcionario : pessoas1
    {
        public Funcionario(string nome, int idade, string cargo) : base(nome, idade)
        {
            Cargo = cargo;
        }
        public string Cargo { get; set; }


        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Cargo: {Cargo}");
        }

    }
}





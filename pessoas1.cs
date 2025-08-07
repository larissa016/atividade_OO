namespace atividade_OO
{
    public class pessoas1(string nome, int idade)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;

        public void Envelhecer(int anos)
        {
            Idade += anos;
            Console.WriteLine($"{Nome} envelheceu {anos} ano(s) e agora tem {Idade} anos.");
        }
    }
}


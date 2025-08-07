using System.ComponentModel;
using atividade_OO;


internal class Program
{


    private static void Main()
    {
        var livro1 = new Livro
        {
            Título = "Livro 1",
            Autor = "Autor 1",
            Editora = "Editora 1",
            AnoDeLancamento = 1899
        };
        Console.WriteLine($"{livro1.Título} | {livro1.Autor} | {livro1.Editora} | {livro1.AnoDeLancamento}");

        var livro2 = new Livro
        {
            Título = "Livro 2",
            Autor = "Autor 2",
            Editora = "Editora 2",
            AnoDeLancamento = 1899
        };

        Console.WriteLine($"{livro2.Título} | {livro2.Autor} | {livro2.Editora} | {livro2.AnoDeLancamento}");

        var livro3 = new Livro
        {
            Título = "Livro 3",
            Autor = "Autor 3",
            Editora = "Editora 3",
            AnoDeLancamento = 2009
        };

        Console.WriteLine($"{livro3.Título} | {livro3.Autor} | {livro3.Editora} | {livro3.AnoDeLancamento}");

        Console.WriteLine("--------------------------------------------------");

        var Aluno1 = new Aluno
        {
            RM = 12345,
            Nome = "João Silva",
            Nascimento = new DateTime(2000, 5, 15),
            Email = "joao.silva@email.com"
        };

        Console.WriteLine($"{Aluno1.RM} | {Aluno1.Nome} | {Aluno1.Nascimento: dd/MM/yyyy} | {Aluno1.Email}");

        var Aluno2 = new Aluno
        {
            RM = 12789,
            Nome = "Nome Aluno 2",
            Nascimento = new DateTime(1998, 8, 22),
            Email = "Email Aluno 2"
        };

        Console.WriteLine($"{Aluno2.RM} | {Aluno2.Nome} | {Aluno2.Nascimento: dd/MM/yyyy} | {Aluno2.Email}");

        var Aluno3 = new Aluno
        {
            RM = 12567,
            Nome = "Nome Aluno 3",
            Nascimento = new DateTime(2009, 5, 2),
            Email = "Email Aluno 3"
        };

        Console.WriteLine($"{Aluno3.RM} | {Aluno3.Nome} | {Aluno3.Nascimento: dd/MM/yyyy} | {Aluno3.Email}");

        Console.WriteLine("--------------------------------------------------");

        var produto1 = new produto
        {
            codigo = 1,
            nome = "caneta",
            preco = 2.20m,
            estoque = 2

        };

        var produto2 = new produto
        {
            codigo = 2,
            nome = "papel",
            preco = 10.50m,
            estoque = 9

        };

        var produto3 = new produto
        {
            codigo = 3,
            nome = "tesoura",
            preco = 9.20m,
            estoque = 7

        };

        Console.WriteLine($"\ncodigo: {produto1.codigo}");
        Console.WriteLine($"nome: {produto1.nome}");
        Console.WriteLine($"preco: {produto1.preco}");
        Console.WriteLine($"estoque: {produto1.estoque}");
        Console.WriteLine($"total em estoque : R${produto1.valorestoque():0.00}");


        Console.WriteLine($"\ncodigo: {produto2.codigo}");
        Console.WriteLine($"nome: {produto2.nome}");
        Console.WriteLine($"preco: {produto2.preco}");
        Console.WriteLine($"estoque: {produto2.estoque}");
        Console.WriteLine($"total em estoque : R${produto2.valorestoque():0.00}");


        Console.WriteLine($"\ncodigo: {produto3.codigo}");
        Console.WriteLine($"nome: {produto3.nome}");
        Console.WriteLine($"preco: {produto3.preco}");
        Console.WriteLine($"estoque: {produto3.estoque}");
        Console.WriteLine($"total em estoque : R${produto3.valorestoque():0.00}");


        var carro1 = new Carro
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Velocidade = 120,
        };

        Console.WriteLine($"\nMarca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Velocidade: {carro1.Velocidade}");
        Console.WriteLine($"Velocidade Atual : {carro1.Acelerar(10)}km/h");
        Console.WriteLine($"Velocidade Atual : {carro1.Acelerar(20)}km/h");
        Console.WriteLine($"Velocidade Atual : {carro1.Desacelerar(15)}km/h");

        var f1 = new Funcionario("Ana", 25, "Analista");
        var f2 = new Funcionario("Bruno", 30, "Desenvolvedor");
        var f3 = new Funcionario("Carla", 40, "Gerente");

        f1.Exibir();
        f2.Exibir();
        f3.Exibir();

        //Envelhecer cada um
        f1.Envelhecer(2);
        f2.Envelhecer(5);
        f3.Envelhecer(1);



        Console.WriteLine("\n--------------------------------------------------");

        var gato = new Gato();
        var porco = new Porco();
        var capivara = new Capivara();

        gato.Exibir();
        gato.EmitirSom();

        porco.Exibir();
        porco.EmitirSom();

        capivara.Exibir();
        capivara.EmitirSom();

        Console.WriteLine("\n--------------------------------------------------");

        Console.WriteLine("\n--------------------------------------------------");
        var Banco1 = new ContaGenerica
        {
            Banco = "Santander",
            Agencia = 1234,
            Conta = 56789 - 0,
            Saldo = 1000.00m
        };


        Console.WriteLine($"Banco: {Banco1.Banco}");
        Console.WriteLine($"Agência: {Banco1.Agencia}");
        Console.WriteLine($"Conta: {Banco1.Conta}");
        Console.WriteLine($"Saldo: {Banco1.Saldo:C}");
        Banco1.Depositar(500.00m);
        Console.WriteLine($"Saldo após depósito: {Banco1.Saldo:C}");
        Banco1.Sacar(200.00m);

        var Banco2 = new ContaGenerica
        {
            Banco = "Itaú",
            Agencia = 5678,
            Conta = 56789 - 0,
            Saldo = 1000.00m
        };
        Console.WriteLine($"Banco: {Banco2.Banco}");
        Console.WriteLine($"Agência: {Banco2.Agencia}");
        Console.WriteLine($"Conta: {Banco2.Conta}");
        Console.WriteLine($"Saldo: {Banco2.Saldo:C}");
        Banco2.Sacar(200.00m);



        var Banco3 = new ContaGenerica
        {
            Banco = "Banco do Brasil",
            Agencia = 1234,
            Conta = 56789 - 0,
            Saldo = 1000.00m
        };
        Console.WriteLine($"Banco: {Banco3.Banco}");
        Console.WriteLine($"Agência: {Banco3.Agencia}");
        Console.WriteLine($"Conta: {Banco3.Conta}");
        Console.WriteLine($"Saldo: {Banco3.Saldo:C}");
        Banco3.Depositar(300.00m);


        Console.WriteLine("\n--------------------------------------------------");


    }
}

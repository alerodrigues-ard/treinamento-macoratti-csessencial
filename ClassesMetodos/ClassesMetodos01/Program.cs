Console.WriteLine("## Classes e Métodos 01 ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Pessoa p2 = new Pessoa();
p2.nome = "Manuel";
p2.idade = 23;
p2.sexo = "masculino";

Console.WriteLine($"{p1.nome} tem {p1.idade} anos e é do sexo {p1.sexo}");
Console.WriteLine($"{p2.nome} tem {p2.idade} anos e é do sexo {p2.sexo}");

Console.WriteLine("\n## Fim do processamento ##\n");

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}

Console.WriteLine("Saída de dados formatada");

int idade = 25;
string nome = "Maria";

// Concatenação
Console.WriteLine("---concatenação---");
Console.WriteLine(nome + " tem " + idade + " anos");

// Interpolação
Console.WriteLine("---interpolação---");
Console.WriteLine($"{nome} tem {idade} anos");

// Place holder (antigo)
Console.WriteLine("---place holder---");
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadKey();





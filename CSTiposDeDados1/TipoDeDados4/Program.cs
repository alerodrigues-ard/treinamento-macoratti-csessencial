Console.WriteLine("Variáveis string, object e dynamic");

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

// Imutabilidade. Duas strings em memória criadas para a mesma variável
string valor = "Isto é uma string";
valor = "Isto é uma string alterada";

/*
object nota = 10;
object valor1 = 8.5m;
object nome1 = "Maria";
object ativa = true;
object letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);
*/

dynamic nota = 10;
dynamic valor1 = 8.5m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();


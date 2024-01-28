Console.WriteLine("Nullable types");

//Nullable<int> valor = null;
int? valor = null;

// Atribuir nullable para não nullable
int valor2 = valor ?? 0;

Console.WriteLine(valor);
Console.WriteLine(valor2);

// Atribuir nullable para não nullable
valor = 100;
valor2 = valor ?? 0;
Console.WriteLine(valor);
Console.WriteLine(valor2);

// Expressões
int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

// Propriedades HasValue e Value

int? b = null;

if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor");
}


Console.ReadKey();


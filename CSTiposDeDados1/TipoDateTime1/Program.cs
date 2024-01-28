Console.WriteLine("Tipo DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//DateTime dataHoje = new DateTime(2023, 08, 30);
DateTime dataHoje = new(2023, 08, 30);
Console.WriteLine(dataHoje);

// extrair informações
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));

Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());

Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.ReadKey();



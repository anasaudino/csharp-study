Console.WriteLine("Digite sua nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua outra nota");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua última nota");
double nota3 = double.Parse(Console.ReadLine());

double media = nota1 + nota2 + nota3 / 3;

Console.WriteLine($"Sua média aritmética final é: {media:F1}");
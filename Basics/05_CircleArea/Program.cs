Console.WriteLine("Digite um numero:");
double numero = int.Parse(Console.ReadLine());

double pi = Math.PI;

numero = pi * Math.Pow(numero, 2);

Console.WriteLine($"A área do círculo é: {numero:F2}");
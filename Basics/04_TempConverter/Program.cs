Console.WriteLine("Digite uma temperatura em Celsius");
int celsius = int.Parse(Console.ReadLine());

int fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"\nA temperatura em Fahrenheit é: {fahrenheit}");
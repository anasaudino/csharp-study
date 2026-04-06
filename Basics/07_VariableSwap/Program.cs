Console.WriteLine("Digite um numero:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero:");
int b = int.Parse(Console.ReadLine());

a = b;
b = a;

Console.WriteLine($"Valor de A: {a} | Valor de B: {b}");

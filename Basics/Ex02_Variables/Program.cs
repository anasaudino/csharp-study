Console.WriteLine("Digite um numero:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro numero:");
int n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;
int subtracao = n1 - n2;
int multiplicacao = n1 * n2;
int divisao = n1 / n2;

Console.WriteLine($"\nSoma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");


using static System.Runtime.InteropServices.JavaScript.JSType;

int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um numero que ficará na posição {i}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine(soma);
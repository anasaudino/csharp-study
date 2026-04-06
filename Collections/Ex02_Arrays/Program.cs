// Collections - Ex02: Arrays
// Arrays: tamanho fixo, acesso por índice

int[] numeros = { 10, 20, 30, 40, 50 };

Console.WriteLine($"Tamanho: {numeros.Length}");
Console.WriteLine($"Primeiro: {numeros[0]}");
Console.WriteLine($"Último:   {numeros[^1]}"); // índice a partir do fim (C# 8+)

Array.Sort(numeros);
Console.WriteLine("Ordenado: " + string.Join(", ", numeros));

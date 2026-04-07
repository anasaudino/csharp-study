List<int> numeros = new List<int>();

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Digite um numero:");
    int n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
    {
        numeros.Add(n);
    }
}

foreach (int numero in numeros)
{
    Console.WriteLine($"Numeros adicionados a lista (somente pares): {numero}");
}

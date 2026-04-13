double soma = 0.0;

for (int i = 1; i <= 100; i++)
{
    soma += 1.0 / i;

    Console.WriteLine($"Soma: {soma:F2} | {i}");
}
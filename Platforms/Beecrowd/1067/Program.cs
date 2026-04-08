Console.WriteLine("Digite um numero:");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($"Posição {i} | Numero: {x}");
    }
}

if (x % 2 == 0)
{
    Console.WriteLine("Digite um numero impar!");
}

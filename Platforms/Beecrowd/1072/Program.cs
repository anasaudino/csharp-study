Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    if (i >= 10 && i <= 20)
    {
        Console.WriteLine($" {i} | Intervalo [10,20]");
    }
    else
    {
        Console.WriteLine($" {i} | Fora de intervalo");
    }
}
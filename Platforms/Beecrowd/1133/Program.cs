Console.WriteLine("Digite um numero:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro numero:");
int y = int.Parse(Console.ReadLine());

int menor = Math.Min(x, y);
int maior = Math.Max(x, y);

for (int i = menor + 1; i < maior; i++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}
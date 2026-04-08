Console.WriteLine("Digite um numero:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro numero:");
int y = int.Parse(Console.ReadLine());

int soma = 0;

if (x % 2 != 0 && y % 2 != 0)
{
    for (int i = x; i <= y; i++)
    {
        i += y;
        Console.WriteLine(i);
    }
}
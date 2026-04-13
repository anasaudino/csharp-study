Console.WriteLine("Digite um numero:");
int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);

    if (i < n - 1)
    {
        Console.Write("");
    }

    int proximo = a + b;
    a = b;
    b = proximo;
}

Console.WriteLine();